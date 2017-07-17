using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace LiveSplit.TheEndIsNigh.Memory
{
	/// <summary>
	/// Static class used to store functions related to Windows memory. Many of these functions are extension methods on the Process class.
	/// </summary>
	public static class MemoryReader
	{
		/// <summary>
		/// Reads a value from the given address.
		/// </summary>
		public static T Read<T>(this Process process, IntPtr address, params int[] offsets) where T : struct
		{
			int last = OffsetAddress(process, ref address, offsets);

			Type type = typeof(T);
			type = type.IsEnum ? Enum.GetUnderlyingType(type) : type;

			int count = type == typeof(bool) ? 1 : Marshal.SizeOf(type);
			byte[] buffer = Read(process, address + last, count);

			return (T)ResolveToType(buffer, type);
		}

		/// <summary>
		/// Converts the given array of bytes to an object of the given type.
		/// </summary>
		private static object ResolveToType(byte[] bytes, Type type)
		{
			if (type == typeof(int))
			{
				return BitConverter.ToInt32(bytes, 0);
			}

			if (type == typeof(uint))
			{
				return BitConverter.ToUInt32(bytes, 0);
			}

			if (type == typeof(float))
			{
				return BitConverter.ToSingle(bytes, 0);
			}

			if (type == typeof(double))
			{
				return BitConverter.ToDouble(bytes, 0);
			}

			if (type == typeof(byte))
			{
				return bytes[0];
			}

			if (type == typeof(bool))
			{
				return bytes != null && bytes[0] > 0;
			}

			if (type == typeof(short))
			{
				return BitConverter.ToInt16(bytes, 0);
			}

			if (type == typeof(ushort))
			{
				return BitConverter.ToUInt16(bytes, 0);
			}

			if (type == typeof(long))
			{
				return BitConverter.ToInt64(bytes, 0);
			}

			if (type == typeof(ulong))
			{
				return BitConverter.ToUInt64(bytes, 0);
			}

			GCHandle gcHandle = GCHandle.Alloc(bytes, GCHandleType.Pinned);

			try
			{
				return Marshal.PtrToStructure(gcHandle.AddrOfPinnedObject(), type);
			}
			finally
			{
				gcHandle.Free();
			}
		}

		/// <summary>
		/// Reads an array of bytes starting at the given address. 
		/// </summary>
		public static byte[] Read(this Process process, IntPtr address, int numBytes)
		{
			byte[] buffer = new byte[numBytes];
			int bytesRead;

			WinAPI.ReadProcessMemory(process.Handle, address, buffer, numBytes, out bytesRead);

			return buffer;
		}
		
		/// <summary>
		/// Offsets the given address.
		/// </summary>
		private static int OffsetAddress(this Process process, ref IntPtr address, params int[] offsets)
		{
			bool is64Bit = Is64Bit(process);
			byte[] buffer = new byte[is64Bit ? 8 : 4];

			for (int i = 0; i < offsets.Length - 1; i++)
			{
				int bytesWritten;

				WinAPI.ReadProcessMemory(process.Handle, address + offsets[i], buffer, buffer.Length, out bytesWritten);

				if (is64Bit)
				{
					address = (IntPtr)BitConverter.ToUInt64(buffer, 0);
				}
				else
				{
					address = (IntPtr)BitConverter.ToUInt32(buffer, 0);
				}
			}

			return offsets.Length > 0 ? offsets[offsets.Length - 1] : 0;
		}

		/// <summary>
		/// Determines whether the given process is 64-bit.
		/// </summary>
		public static bool Is64Bit(this Process process)
		{
			bool flag;

			WinAPI.IsWow64Process(process.Handle, out flag);

			return Environment.Is64BitOperatingSystem && !flag;
		}

		/// <summary>
		/// Static class storing Windows API functions.
		/// </summary>
		private static class WinAPI
		{
			[DllImport("kernel32.dll", SetLastError = true)]
			public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

			[DllImport("kernel32.dll", SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool IsWow64Process(IntPtr hProcess, [MarshalAs(UnmanagedType.Bool)] out bool wow64Process);
		}
	}
}
