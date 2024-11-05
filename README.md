# HD44780 custom symbol creating tool

Utility for creating custom symbols for LCD displays based on the HD44780 controller

![screen](https://github.com/user-attachments/assets/336a04e4-7d50-4be8-8f15-eb77e88df755)

## Usage

* Draw the desired symbol on a special field (`5x8`) with the left mouse button held down.
  - left mouse button - paint pixel
  - right mouse button - clear pixel
* copy the resulting array from the text field on the right

## Capabilities

* Saving a symbol to a file / opening a previously saved symbol from a file

* Built-in symbol table (`5x7 px`). A symbol can be found by directly entering it in the "Symbol" field or entering its code in the "Char code" field (in the decimal number system `48` or in hexadecimal `30h`)

![charmap](https://github.com/user-attachments/assets/9f7a6cf9-e5b0-4380-8964-374c2dcd7374)

* Editing a symbol image
  - Clearing the entire field
  - Filling out the entire field
  - Flip the image horizontally
  - Flip the image vertically
  - Image inversion
