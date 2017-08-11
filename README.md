# LiveSplit.TheEndIsNigh
Autosplitter for The End Is Nigh.

## Setup instructions

- Before you start, you'll need [LiveSplit](http://livesplit.github.io/downloads) (the most recent version is 1.7.4).
- Go to the [releases](https://github.com/Grimelios/LiveSplit.TheEndIsNigh/releases) section of this repository.
- Download **LiveSplit.TheEndIsNigh.dll**. You do **not** need to download the full source code.
- Place the DLL inside your LiveSplit/Components folder.
- Open LiveSplit, edit layout, and add the autosplitter (under the Control section).
- Configure the autosplitter for whatever splits you're using, optionally using default splits.

## Additional notes

- The autosplitter's splits are separate from your main LiveSplit splits. In other words, the autosplitter will **not** auto-configure itself based on your existing splits.
- That said, your autosplitter settings should include the same number of splits as your main splits (to ensure the autosplitter splits the correct number of times).
- Splits should be configured for the **end** of whatever section you're on. For example, to split at the end of The End, select Arid Flats (i.e. you want to split when you enter Arid Flats).
- The default split buttons are just a convenience. After clicking one, you can still freely modify splits depending on your preferred route.
- After you've manually set up the autosplitter once, it will automatically update itself going forward (when you restart LiveSplit).
