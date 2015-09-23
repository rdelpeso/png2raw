# png2raw

## Summary

Probably not the best named project. But its main function is to provide a way
of converting simple image formats (png/jpg) into OSRAW files. Which these in
turn can be used to modify terrain via a viewer in either SecondLife or OpenSim.

This app replaces the need for users to know how to manage the OpenSim console
in order to use a PNG as the basis for the terrain in their regions. Viewers
now days only support the upload of RAW files when modifying the terrain. But
there is a serious lack of a simple app that translates a png made in paint or
any other image software into the RAW format. So we provide a GUI tool and a
command line tool to achieve this.

## GUI How to use

- Open the binary file (Available Soon)
- Click Load Source
- Select a compatible image and open it
- Once the image is visible within the left picture frame click Convert Source
- The image will be copied over to the right picture frame and be grayscaled
- Select an appropiate multipler (the smaller the better quality but the smaller
  the hills in terrain)
- Click Save Raw
- Import the resulting .raw file into a SL/OS viewer to replace the terrain
- (Optionally) Edit the terrain and raise the whole land plot to make the
  terrain show above water if needed.

## OSRAW?

OSRAW - OpenSim RAW format. (proper wording in progress)

Is a special format in which data is arranged in 13 channels or 8bits. Of which
only 3 are used.

    01 02 03 04 05 06 07 08 09 10 11 12 13
    --------------------------------------
    10 10 20 00 00 00 00 00 00 00 00 00 00
    15 10 20 00 00 00 00 00 00 00 00 00 00

Channel 01: Elevation
Channel 02: Multiplier
Channel 03: Water Level
Channles 04-13: not used as far as I know

When OpenSim reads the RAW file it reads the first 3 bytes into variables (val,
mul, water) and discards the following 10. This data will be translated into
either a 16bit or 64bit internal representation. Here is the formula used for
the value and multiplier prior to being saved into the database:

    value * (multiplier / 128)

This results in some interesting issues, like loosing resolution the higher the
multipler becomes etc. There is plenty research left to figureout how to avoid
this as well as the use of Variable Multiplier (which means each value has its
own multiplier instead of using the same multiplier in the entire raw file).

More info coming in the future.
