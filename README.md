# Comentsys.Assets.Games

**Comentsys.Assets.Games** is an **Asset Resource** in **.NET Standard** for **Games** using **Comentsys.Toolkit** including:

- **Chess** from [commons.wikimedia.org/wiki/Template:SVG_chess_pieces](https://commons.wikimedia.org/wiki/Template:SVG_chess_pieces) designed by **Cburnett**
- **Mahjong** from [commons.wikimedia.org/wiki/User:Shizhao/Mahjong](https://commons.wikimedia.org/wiki/User:Shizhao/Mahjong) designed by **Shizhao**
- **Playing Cards** from [commons.wikimedia.org/wiki/Category:SVG_playing_cards_6](https://commons.wikimedia.org/wiki/Category:SVG_playing_cards_6) designed by **TheRealRevK**
- **Dice**, **Dominoes**, **Pieces** and **Boards** designed by **Comentsys**

## Change Log

### Version 2.0.0

- Add Playing Cards, Dice, Dominoes, Piece and Board

### Version 1.1.0

- Update for Comentsys.Toolkit

### Version 1.0.0

- Initial Release

## ChessPiece

`ChessPiece` represents **Chess Pieces** and were originally designed by **Cburnett**. You can also customise the **Colours** used as **Black** and **White** for the **Chess Pieces** of either **Set** to create a customised experience.

### Examples

#### White

![Chess - White](https://raw.githubusercontent.com/Comentsys/Comentsys.Assets.Games/refs/heads/main/Assets/chess-white.png)

#### Black

![Chess - Black](https://raw.githubusercontent.com/Comentsys/Comentsys.Assets.Games/refs/heads/main/Assets/chess-black.png)

### Get(set, type, black, white)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `set` | `Comentsys.Assets.Games.ChessPieceSet`<br>Chess Piece Set |
| `type` | `Comentsys.Assets.Games.ChessPieceType`<br>Chess Piece Type |
| `black` | `System.Drawing.Color?`<br>Replacement Black Colour |
| `white` | `System.Drawing.Color?`<br>Replacement White Colour |

#### Returns

Asset Resource

### ChessPieceSet

`ChessPieceSet` represents the `Black` and `White` sets of **Chess Pieces**.

#### Black

Black Chess Pieces

#### White

White Chess Pieces

### ChessPieceType

`ChessPieceType` supports the following **Chess Pieces**

```
Pawn,
Knight,
Bishop,
Rook,
King,
Queen
```

## MahjongTile

`MahjongTile` represents **Mahjong Tiles** and were orginally designed by **Shizhao** and put into the **Public Domain**. You can also customise the **Colours** used by the **Mahjong Tiles** with either a single **Colour** or an **Array** of **Colours** to create customised **Mahjong Tiles**.

### Examples

![Mahjong](https://raw.githubusercontent.com/Comentsys/Comentsys.Assets.Games/refs/heads/main/Assets/mahjong.png)

### Get(type, sources, targets)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `type` | `Comentsys.Assets.Games.MahjongTileType`<br>Mahjong Tile Type |
| `sources` | `System.Drawing.Color[]?`<br>Source Colours |
| `targets` | `System.Drawing.Color[]?`<br>Target Colours |

#### Returns

Asset Resource

### Get(type, source, target)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `type` | `Comentsys.Assets.Games.MahjongTileType`<br>Mahjong Tile Type |
| `source` | `System.Drawing.Color?`<br>Source Colour |
| `target` | `System.Drawing.Color?`<br>Target Colour |

#### Returns

Asset Resource

### Get(type)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `type` | `Comentsys.Assets.Games.MahjongTileType`<br>Mahjong Tile Type |

#### Returns

Asset Resource

### MahjongTileType

`MahjongTileType` supports the following **Mahjong Tiles** as well as `Back` representing the **Back** of a **Mahjong Tile**.

```
Back
EastWind,
SouthWind,
WestWind,
NorthWind,
RedDragon,
GreenDragon,
WhiteDragon,
OneOfCharacters,
TwoOfCharacters,
ThreeOfCharacters,
FourOfCharacters,
FiveOfCharacters,
SixOfCharacters,
SevenOfCharacters,
EightOfCharacters,
NineOfCharacters,
OneOfBamboos,
TwoOfBamboos,
ThreeOfBamboos,
FourOfBamboos,
FiveOfBamboos,
SixOfBamboos,
SevenOfBamboos,
EightOfBamboos,
NineOfBamboos,
OneOfCircles,
TwoOfCircles,
ThreeOfCircles,
FourOfCircles,
FiveOfCircles,
SixOfCircles,
SevenOfCircles,
EightOfCircles,
NineOfCircles,
Plum,
Orchid,
Bamboo,
Chrysanthemum,
Spring,
Summer,
Autumn,
Winter,
Joker
```

## PlayingCard

`PlayingCard` represents **Playing Cards** and were orginally designed by **TheRealRevK** and put into the **Public Domain**. You can also customise the **Colours** used by the **Playing Cards** with either a single **Colour** or an **Array** of **Colours** to create customised **Playing Cards**.

### Examples

![Playing Cards](https://raw.githubusercontent.com/Comentsys/Comentsys.Assets.Games/refs/heads/main/Assets/playingcards.png)

### Get(type, sources, targets)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `type` | `Comentsys.Assets.Games.PlayingCardType`<br>Playing Card Type |
| `sources` | `System.Drawing.Color[]?`<br>Source Colours |
| `targets` | `System.Drawing.Color[]?`<br>Target Colours |

#### Returns

Asset Resource

### Get(type, source, target)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `type` | `Comentsys.Assets.Games.PlayingCardType`<br>Playing Card Type |
| `source` | `System.Drawing.Color?`<br>Source Colour |
| `target` | `System.Drawing.Color?`<br>Target Colour |

#### Returns

Asset Resource

### Get(type)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `type` | `Comentsys.Assets.Games.PlayingCardType`<br>PlayingCard Tile Type |

#### Returns

Asset Resource

### Get(value, sources, targets)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `value` | `System.Int32`<br>Playing Card Type Value |
| `sources` | `System.Drawing.Color[]?`<br>Source Colours |
| `targets` | `System.Drawing.Color[]?`<br>Target Colours |

#### Returns

Asset Resource

### Get(value, source, target)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `value` | `System.Int32`<br>Playing Card Type Value |
| `source` | `System.Drawing.Color?`<br>Source Colour |
| `target` | `System.Drawing.Color?`<br>Target Colour |

#### Returns

Asset Resource

### Get(value)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `value` | `System.Int32`<br>PlayingCard Tile Type Value |

#### Returns

Asset Resource

### PlayingCardType

`PlayingCardType` supports the following **Playing Cards** as well as `Back` representing the **Back** of a **Playing Card**.

```
Back
AceOfClubs
TwoOfClubs
ThreeOfClubs
FourOfClubs
FiveOfClubs
SixOfClubs
SevenOfClubs
EightOfClubs
NineOfClubs
TenOfClubs
JackOfClubs
QueenOfClubs
KingOfClubs
AceOfDiamonds
TwoOfDiamonds
ThreeOfDiamonds
FourOfDiamonds
FiveOfDiamonds
SixOfDiamonds
SevenOfDiamonds
EightOfDiamonds
NineOfDiamonds
TenOfDiamonds
JackOfDiamonds
QueenOfDiamonds
KingOfDiamonds
AceOfHearts
TwoOfHearts
ThreeOfHearts
FourOfHearts
FiveOfHearts
SixOfHearts
SevenOfHearts
EightOfHearts
NineOfHearts
TenOfHearts
JackOfHearts
QueenOfHearts
KingOfHearts
AceOfSpades
TwoOfSpades
ThreeOfSpades
FourOfSpades
FiveOfSpades
SixOfSpades
SevenOfSpades
EightOfSpades
NineOfSpades
TenOfSpades
JackOfSpades
QueenOfSpades
KingOfSpades
```

## DiceFace

`DiceFace` represents a **Dice Face**. You can also customise the **Colours** used by the **Dice** with a single **Colour** for the **Fill** or an **Array** of **Colours** for the **Pips** along with setting the **Stroke** to create customised **Dice** in either **Rounded** or **Square** styles.

### Examples

#### Rounded

![Dice - Rounded](https://raw.githubusercontent.com/Comentsys/Comentsys.Assets.Games/refs/heads/main/Assets/dice-rounded.png)

#### Square

![Dice - Square](https://raw.githubusercontent.com/Comentsys/Comentsys.Assets.Games/refs/heads/main/Assets/dice-square.png)

### Get(value, fill, stroke, pips, style)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `value` | `Comentsys.Assets.Games.DiceFaceValue`<br>Dice Face Value |
| `fill` | `System.Drawing.Color?`<br>Fill Colour |
| `stroke` | `System.Drawing.Color?`<br>Stroke Colour |
| `pips` | `System.Drawing.Color[]?`<br>Pip Colours |
| `style` | `Comentsys.Assets.Games.DiceFaceStyle?`<br>Dice Face Style |

#### Returns

Asset Resource

### Get(value, fill, stroke, pip, style)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `value` | `Comentsys.Assets.Games.DiceFaceValue`<br>Dice Face Value |
| `fill` | `System.Drawing.Color?`<br>Fill Colour |
| `stroke` | `System.Drawing.Color?`<br>Stroke Colour |
| `pips` | `System.Drawing.Color?`<br>Pip Colour |
| `style` | `Comentsys.Assets.Games.DiceFaceStyle?`<br>Dice Face Style |

#### Returns

Asset Resource

### Get(type, style)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `value` | `Comentsys.Assets.Games.DiceFaceValue`<br>Dice Face Value |
| `style` | `Comentsys.Assets.Games.DiceFaceStyle?`<br>Dice Face Style |

#### Returns

Asset Resource

### Get(value, fill, stroke, pips, style)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `value` | `System.Int32`<br>Value |
| `fill` | `System.Drawing.Color?`<br>Fill Colour |
| `stroke` | `System.Drawing.Color?`<br>Stroke Colour |
| `pips` | `System.Drawing.Color[]?`<br>Pip Colours |
| `style` | `Comentsys.Assets.Games.DiceFaceStyle?`<br>Dice Face Style |

#### Returns

Asset Resource

### Get(value, fill, stroke, pip, style)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `value` | `System.Int32`<br> Value |
| `fill` | `System.Drawing.Color?`<br>Fill Colour |
| `stroke` | `System.Drawing.Color?`<br>Stroke Colour |
| `pips` | `System.Drawing.Color?`<br>Pip Colour |
| `style` | `Comentsys.Assets.Games.DiceFaceStyle?`<br>Dice Face Style |

#### Returns

Asset Resource

### Get(type, style)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `value` | `System.Int32`<br>Value |
| `style` | `Comentsys.Assets.Games.DiceFaceStyle?`<br>Dice Face Style |

#### Returns

Asset Resource

### DiceFaceValue

`DiceFaceValue` supports the following **Dice Faces** as well as `Blank`.

```
Blank
One
Two
Three
Four
Five
Six
```

### DiceFaceStyle

`DiceFaceStyle` represents the `Rounded` and `Square` style of **Dice**.

#### Rounded

Rounded Dice Face Style

#### Square

Square Dice Face Style

## Domino

`Domino` represents a **Domino** that can be **Vertical** or **Horizontal**. You can also customise the **Colours** used by the **Domino** with a single **Colour** for the **Fill** or an **Array** of **Colours** for the **Pips**, which is shared by the **Divider**, along with setting the **Stroke** to create a customised **Domino** in either **Rounded** or **Square** styles.

### Examples

#### Vertical Rounded

![Domino - Vertical - Rounded](https://raw.githubusercontent.com/Comentsys/Comentsys.Assets.Games/refs/heads/main/Assets/domino-vertical-rounded.png)

#### Vertical Square

![Domino - Vertical - Square](https://raw.githubusercontent.com/Comentsys/Comentsys.Assets.Games/refs/heads/main/Assets/domino-vertical-square.png)

#### Horizontal Rounded

![Domino - Horizontal - Rounded](https://raw.githubusercontent.com/Comentsys/Comentsys.Assets.Games/refs/heads/main/Assets/domino-horizontal-rounded.png)

#### Horizontal Square

![Domino - Horizontal - Square](https://raw.githubusercontent.com/Comentsys/Comentsys.Assets.Games/refs/heads/main/Assets/domino-horizontal-square.png)

### Get(value, fill, stroke, pips, set, style)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `value` | `Comentsys.Assets.Games.DominoValue`<br>Domino Value |
| `fill` | `System.Drawing.Color?`<br>Fill Colour |
| `stroke` | `System.Drawing.Color?`<br>Stroke Colour |
| `pips` | `System.Drawing.Color[]?`<br>Pip Colours |
| `set` | `Comentsys.Assets.Games.DominoSet?`<br>Domino Set |
| `style` | `Comentsys.Assets.Games.DominoStyle?`<br>Domino Style |

#### Returns

Asset Resource

### Get(value, fill, stroke, pip, set, style)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `value` | `Comentsys.Assets.Games.DominoValue`<br>Domino Value |
| `fill` | `System.Drawing.Color?`<br>Fill Colour |
| `stroke` | `System.Drawing.Color?`<br>Stroke Colour |
| `pip` | `System.Drawing.Color?`<br>Pip Colour |
| `set` | `Comentsys.Assets.Games.DominoSet?`<br>Domino Set |
| `style` | `Comentsys.Assets.Games.DominoStyle?`<br>Domino Style |

#### Returns

Asset Resource

### Get(type, set, style)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `value` | `Comentsys.Assets.Games.DominoValue`<br>Domino Value |
| `set` | `Comentsys.Assets.Games.DominoSet?`<br>Domino Set |
| `style` | `Comentsys.Assets.Games.DominoStyle?`<br>Domino Style |

#### Returns

Asset Resource

### Get(value, fill, stroke, pips, set, style)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `value` | `System.Int32`<br> Value |
| `fill` | `System.Drawing.Color?`<br>Fill Colour |
| `stroke` | `System.Drawing.Color?`<br>Stroke Colour |
| `pips` | `System.Drawing.Color[]?`<br>Pip Colours |
| `set` | `Comentsys.Assets.Games.DominoSet?`<br>Domino Set |
| `style` | `Comentsys.Assets.Games.DominoStyle?`<br>Domino Style |

#### Returns

Asset Resource

### Get(value, fill, stroke, pip, set, style)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `value` | `System.Int32`<br> Value |
| `fill` | `System.Drawing.Color?`<br>Fill Colour |
| `stroke` | `System.Drawing.Color?`<br>Stroke Colour |
| `pip` | `System.Drawing.Color?`<br>Pip Colour |
| `set` | `Comentsys.Assets.Games.DominoSet?`<br>Domino Set |
| `style` | `Comentsys.Assets.Games.DominoStyle?`<br>Domino Style |

#### Returns

Asset Resource

### Get(type, set, style)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `value` | `System.Int32`<br> Value |
| `set` | `Comentsys.Assets.Games.DominoSet?`<br>Domino Set |
| `style` | `Comentsys.Assets.Games.DominoStyle?`<br>Domino Style |

#### Returns

Asset Resource

### DominoValue

`DominoValue` supports the following **Dominos** as well as `Back` representing the **Back** of a **Domino**.

```
Back
DoubleZero
ZeroOne
ZeroTwo
ZeroThree
ZeroFour
ZeroFive
ZeroSix
DoubleOne
OneTwo
OneThree
OneFour
OneFive
OneSix
DoubleTwo
TwoThree
TwoFour
TwoFive
TwoSix
DoubleThree
ThreeFour
ThreeFive
ThreeSix
DoubleFour
FourFive
FourSix
DoubleFive
FiveSix
DoubleSix
```

### DominoSet

`DominoSet` represents the `Vertical` and `Horizontal` set of **Dominos**.

#### Vertical

Vertical Domino Set

#### Horizontal

Horizontal Domino Set

### DominoStyle

`DominoStyle` represents the `Rounded` and `Square` style of **Dominos**.

#### Rounded

Rounded Domino Style

#### Square

Squared Domino Style

## GamePiece

`GamePiece` represents a **Piece** for a **Game** that can be a **Circle**, **Square**, **Rounded** or a **Hexagon** from a **Set** of **Regular**, **Medium** or **Light**. You can also customise the **Colours** used by the **Piece** including the **Fill** and **Stroke** along with the **Foreground** used for an optional **Value** to create a customised **Piece**.

### Examples

#### Regular

![Regular](https://raw.githubusercontent.com/Comentsys/Comentsys.Assets.Games/refs/heads/main/Assets/piece-regular.png)

#### Regular - Custom

![Regular - Custom](https://raw.githubusercontent.com/Comentsys/Comentsys.Assets.Games/refs/heads/main/Assets/piece-regular-custom.png)

#### Medium

![Medium](https://raw.githubusercontent.com/Comentsys/Comentsys.Assets.Games/refs/heads/main/Assets/piece-medium.png)

#### Medium - Custom

![Medium - Custom](https://raw.githubusercontent.com/Comentsys/Comentsys.Assets.Games/refs/heads/main/Assets/piece-medium-custom.png)

#### Light

![Light](https://raw.githubusercontent.com/Comentsys/Comentsys.Assets.Games/refs/heads/main/Assets/piece-light.png)

#### Light - Custom

![Light - Custom](https://raw.githubusercontent.com/Comentsys/Comentsys.Assets.Games/refs/heads/main/Assets/piece-light-custom.png)

### Get(set, type, fill, stroke, foreground, value)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `set` | `Comentsys.Assets.Games.DominoStyle?`<br>Game Piece Set |
| `type` | `Comentsys.Assets.Games.GamePieceType?`<br>Game Piece Type |
| `fill` | `System.Drawing.Color?`<br>Fill Colour |
| `stroke` | `System.Drawing.Color?`<br>Stroke Colour |
| `foreground` | `System.Drawing.Color?`<br>Foreground Colour |
| `value` | `System.String`<br> Value |

#### Returns

Asset Resource

### GamePieceSet

`GamePieceSet` supports the following sets of **Piece**

#### Regular

Regular Game Piece

#### Medium

Medium Game Piece

### Light

Light Game Piece

### GamePieceType

`GamePieceType` supports the following types of **Piece**

```
Circle
Square
Rounded
Hexagon
```

## GameBoard

`GameBoard` represents a **Board** for a **Game** made up of **Squares** that has **Designs** for **Chess**, **Draughts** / **Checkers**, or **Reversi** / **Othello** or choose a **Type** from **One by One** up to **Ten by Ten**. You can also customise the **Colours** used by the **Board** including the **Squares** with **Primary** and **Secondary** or set them how you need with **Fill** along with **Stroke** plus you can set the **Foreground** for any **Labels** to create a custom **Board**.

### Examples

#### Design - Chess

![Design - Chess](https://raw.githubusercontent.com/Comentsys/Comentsys.Assets.Games/refs/heads/main/Assets/board-chess.png)

#### Design - Draughts / Checkers

![Design - Draughts](https://raw.githubusercontent.com/Comentsys/Comentsys.Assets.Games/refs/heads/main/Assets/board-draughts.png)

#### Design - Reversi / Othello

![Design - Reversi](https://raw.githubusercontent.com/Comentsys/Comentsys.Assets.Games/refs/heads/main/Assets/board-reversi.png)

#### Board Types

![Board Types](https://raw.githubusercontent.com/Comentsys/Comentsys.Assets.Games/refs/heads/main/Assets/board.png)

### Get(type, primary, secondary, stroke, foreground, labels, showLabels)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `type` | `Comentsys.Assets.Games.GameBoardType?`<br>Game Board Type |
| `primary` | `System.Drawing.Color?`<br>Primary Board Colour |
| `secondary` | `System.Drawing.Color?`<br>Secondary Board Colour |
| `stroke` | `System.Drawing.Color?`<br>Board Stroke Colour |
| `foreground` | `System.Drawing.Color?`<br>Label Foreground Colour |
| `labels` | `System.String[]?`<br>Board Labels |
| `showLabels` | `System.Boolean`<br> Show Board Labels? |

#### Returns

Asset Resource

### Get(type, fill, stroke, foreground, labels, showLabels)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `type` | `Comentsys.Assets.Games.GameBoardType?`<br>Game Board Type |
| `fill` | `System.Drawing.Color[]?`<br>Board Fill Colours |
| `stroke` | `System.Drawing.Color?`<br>Board Stroke Colour |
| `foreground` | `System.Drawing.Color?`<br>Label Foreground Colour |
| `labels` | `System.String[]?`<br>Board Labels |
| `showLabels` | `System.Boolean`<br> Show Board Labels? |

#### Returns

Asset Resource

### Get(type, foreground, labels, showLabels)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `type` | `Comentsys.Assets.Games.GameBoardType?`<br>Game Board Type |
| `foreground` | `System.Drawing.Color?`<br>Label Foreground Colour |
| `labels` | `System.String[]?`<br>Board Labels |
| `showLabels` | `System.Boolean`<br> Show Board Labels? |

#### Returns

Asset Resource

### Get(design, showLabels)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `design` | `Comentsys.Assets.Games.GameBoardDesign?`<br>Game Board Design |
| `showLabels` | `System.Boolean`<br> Show Board Labels? |

#### Returns

Asset Resource

### GameBoardDesign

`GameBoardDesign` supports the following designs of **Board**

#### Chess

Chess Board Design

#### Draughts

Draughts or Checkers Board Design

#### Reversi

Reversi or Othello Board Design

### GameBoardType

`GameBoardType` supports the following types of **Board**

```
OneByOne
TwoByTwo
ThreeByThree
FourByFour
FiveByFive
SixBySix
SevenBySeven
EightByEight
NineByNine
TenByTen
```

## Licences

### Package / Dice, Domino, Piece and Board

```
The MIT License (MIT)

Copyright (c) 2025 Comentsys

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
```

### Mahjong Tiles

```
Public Domain

I grant anyone the right to use this work for any purpose, without any conditions, unless such conditions are required by law.
```

### Chess Pieces

```
Creative Commons Legal Code

Attribution-ShareAlike 3.0 Unported

    CREATIVE COMMONS CORPORATION IS NOT A LAW FIRM AND DOES NOT PROVIDE
    LEGAL SERVICES. DISTRIBUTION OF THIS LICENSE DOES NOT CREATE AN
    ATTORNEY-CLIENT RELATIONSHIP. CREATIVE COMMONS PROVIDES THIS
    INFORMATION ON AN "AS-IS" BASIS. CREATIVE COMMONS MAKES NO WARRANTIES
    REGARDING THE INFORMATION PROVIDED, AND DISCLAIMS LIABILITY FOR
    DAMAGES RESULTING FROM ITS USE.

License

THE WORK (AS DEFINED BELOW) IS PROVIDED UNDER THE TERMS OF THIS CREATIVE
COMMONS PUBLIC LICENSE ("CCPL" OR "LICENSE"). THE WORK IS PROTECTED BY
COPYRIGHT AND/OR OTHER APPLICABLE LAW. ANY USE OF THE WORK OTHER THAN AS
AUTHORIZED UNDER THIS LICENSE OR COPYRIGHT LAW IS PROHIBITED.

BY EXERCISING ANY RIGHTS TO THE WORK PROVIDED HERE, YOU ACCEPT AND AGREE
TO BE BOUND BY THE TERMS OF THIS LICENSE. TO THE EXTENT THIS LICENSE MAY
BE CONSIDERED TO BE A CONTRACT, THE LICENSOR GRANTS YOU THE RIGHTS
CONTAINED HERE IN CONSIDERATION OF YOUR ACCEPTANCE OF SUCH TERMS AND
CONDITIONS.

1. Definitions

 a. "Adaptation" means a work based upon the Work, or upon the Work and
    other pre-existing works, such as a translation, adaptation,
    derivative work, arrangement of music or other alterations of a
    literary or artistic work, or phonogram or performance and includes
    cinematographic adaptations or any other form in which the Work may be
    recast, transformed, or adapted including in any form recognizably
    derived from the original, except that a work that constitutes a
    Collection will not be considered an Adaptation for the purpose of
    this License. For the avoidance of doubt, where the Work is a musical
    work, performance or phonogram, the synchronization of the Work in
    timed-relation with a moving image ("synching") will be considered an
    Adaptation for the purpose of this License.
 b. "Collection" means a collection of literary or artistic works, such as
    encyclopedias and anthologies, or performances, phonograms or
    broadcasts, or other works or subject matter other than works listed
    in Section 1(f) below, which, by reason of the selection and
    arrangement of their contents, constitute intellectual creations, in
    which the Work is included in its entirety in unmodified form along
    with one or more other contributions, each constituting separate and
    independent works in themselves, which together are assembled into a
    collective whole. A work that constitutes a Collection will not be
    considered an Adaptation (as defined below) for the purposes of this
    License.
 c. "Creative Commons Compatible License" means a license that is listed
    at https://creativecommons.org/compatiblelicenses that has been
    approved by Creative Commons as being essentially equivalent to this
    License, including, at a minimum, because that license: (i) contains
    terms that have the same purpose, meaning and effect as the License
    Elements of this License; and, (ii) explicitly permits the relicensing
    of adaptations of works made available under that license under this
    License or a Creative Commons jurisdiction license with the same
    License Elements as this License.
 d. "Distribute" means to make available to the public the original and
    copies of the Work or Adaptation, as appropriate, through sale or
    other transfer of ownership.
 e. "License Elements" means the following high-level license attributes
    as selected by Licensor and indicated in the title of this License:
    Attribution, ShareAlike.
 f. "Licensor" means the individual, individuals, entity or entities that
    offer(s) the Work under the terms of this License.
 g. "Original Author" means, in the case of a literary or artistic work,
    the individual, individuals, entity or entities who created the Work
    or if no individual or entity can be identified, the publisher; and in
    addition (i) in the case of a performance the actors, singers,
    musicians, dancers, and other persons who act, sing, deliver, declaim,
    play in, interpret or otherwise perform literary or artistic works or
    expressions of folklore; (ii) in the case of a phonogram the producer
    being the person or legal entity who first fixes the sounds of a
    performance or other sounds; and, (iii) in the case of broadcasts, the
    organization that transmits the broadcast.
 h. "Work" means the literary and/or artistic work offered under the terms
    of this License including without limitation any production in the
    literary, scientific and artistic domain, whatever may be the mode or
    form of its expression including digital form, such as a book,
    pamphlet and other writing; a lecture, address, sermon or other work
    of the same nature; a dramatic or dramatico-musical work; a
    choreographic work or entertainment in dumb show; a musical
    composition with or without words; a cinematographic work to which are
    assimilated works expressed by a process analogous to cinematography;
    a work of drawing, painting, architecture, sculpture, engraving or
    lithography; a photographic work to which are assimilated works
    expressed by a process analogous to photography; a work of applied
    art; an illustration, map, plan, sketch or three-dimensional work
    relative to geography, topography, architecture or science; a
    performance; a broadcast; a phonogram; a compilation of data to the
    extent it is protected as a copyrightable work; or a work performed by
    a variety or circus performer to the extent it is not otherwise
    considered a literary or artistic work.
 i. "You" means an individual or entity exercising rights under this
    License who has not previously violated the terms of this License with
    respect to the Work, or who has received express permission from the
    Licensor to exercise rights under this License despite a previous
    violation.
 j. "Publicly Perform" means to perform public recitations of the Work and
    to communicate to the public those public recitations, by any means or
    process, including by wire or wireless means or public digital
    performances; to make available to the public Works in such a way that
    members of the public may access these Works from a place and at a
    place individually chosen by them; to perform the Work to the public
    by any means or process and the communication to the public of the
    performances of the Work, including by public digital performance; to
    broadcast and rebroadcast the Work by any means including signs,
    sounds or images.
 k. "Reproduce" means to make copies of the Work by any means including
    without limitation by sound or visual recordings and the right of
    fixation and reproducing fixations of the Work, including storage of a
    protected performance or phonogram in digital form or other electronic
    medium.

2. Fair Dealing Rights. Nothing in this License is intended to reduce,
limit, or restrict any uses free from copyright or rights arising from
limitations or exceptions that are provided for in connection with the
copyright protection under copyright law or other applicable laws.

3. License Grant. Subject to the terms and conditions of this License,
Licensor hereby grants You a worldwide, royalty-free, non-exclusive,
perpetual (for the duration of the applicable copyright) license to
exercise the rights in the Work as stated below:

 a. to Reproduce the Work, to incorporate the Work into one or more
    Collections, and to Reproduce the Work as incorporated in the
    Collections;
 b. to create and Reproduce Adaptations provided that any such Adaptation,
    including any translation in any medium, takes reasonable steps to
    clearly label, demarcate or otherwise identify that changes were made
    to the original Work. For example, a translation could be marked "The
    original work was translated from English to Spanish," or a
    modification could indicate "The original work has been modified.";
 c. to Distribute and Publicly Perform the Work including as incorporated
    in Collections; and,
 d. to Distribute and Publicly Perform Adaptations.
 e. For the avoidance of doubt:

     i. Non-waivable Compulsory License Schemes. In those jurisdictions in
        which the right to collect royalties through any statutory or
        compulsory licensing scheme cannot be waived, the Licensor
        reserves the exclusive right to collect such royalties for any
        exercise by You of the rights granted under this License;
    ii. Waivable Compulsory License Schemes. In those jurisdictions in
        which the right to collect royalties through any statutory or
        compulsory licensing scheme can be waived, the Licensor waives the
        exclusive right to collect such royalties for any exercise by You
        of the rights granted under this License; and,
   iii. Voluntary License Schemes. The Licensor waives the right to
        collect royalties, whether individually or, in the event that the
        Licensor is a member of a collecting society that administers
        voluntary licensing schemes, via that society, from any exercise
        by You of the rights granted under this License.

The above rights may be exercised in all media and formats whether now
known or hereafter devised. The above rights include the right to make
such modifications as are technically necessary to exercise the rights in
other media and formats. Subject to Section 8(f), all rights not expressly
granted by Licensor are hereby reserved.

4. Restrictions. The license granted in Section 3 above is expressly made
subject to and limited by the following restrictions:

 a. You may Distribute or Publicly Perform the Work only under the terms
    of this License. You must include a copy of, or the Uniform Resource
    Identifier (URI) for, this License with every copy of the Work You
    Distribute or Publicly Perform. You may not offer or impose any terms
    on the Work that restrict the terms of this License or the ability of
    the recipient of the Work to exercise the rights granted to that
    recipient under the terms of the License. You may not sublicense the
    Work. You must keep intact all notices that refer to this License and
    to the disclaimer of warranties with every copy of the Work You
    Distribute or Publicly Perform. When You Distribute or Publicly
    Perform the Work, You may not impose any effective technological
    measures on the Work that restrict the ability of a recipient of the
    Work from You to exercise the rights granted to that recipient under
    the terms of the License. This Section 4(a) applies to the Work as
    incorporated in a Collection, but this does not require the Collection
    apart from the Work itself to be made subject to the terms of this
    License. If You create a Collection, upon notice from any Licensor You
    must, to the extent practicable, remove from the Collection any credit
    as required by Section 4(c), as requested. If You create an
    Adaptation, upon notice from any Licensor You must, to the extent
    practicable, remove from the Adaptation any credit as required by
    Section 4(c), as requested.
 b. You may Distribute or Publicly Perform an Adaptation only under the
    terms of: (i) this License; (ii) a later version of this License with
    the same License Elements as this License; (iii) a Creative Commons
    jurisdiction license (either this or a later license version) that
    contains the same License Elements as this License (e.g.,
    Attribution-ShareAlike 3.0 US)); (iv) a Creative Commons Compatible
    License. If you license the Adaptation under one of the licenses
    mentioned in (iv), you must comply with the terms of that license. If
    you license the Adaptation under the terms of any of the licenses
    mentioned in (i), (ii) or (iii) (the "Applicable License"), you must
    comply with the terms of the Applicable License generally and the
    following provisions: (I) You must include a copy of, or the URI for,
    the Applicable License with every copy of each Adaptation You
    Distribute or Publicly Perform; (II) You may not offer or impose any
    terms on the Adaptation that restrict the terms of the Applicable
    License or the ability of the recipient of the Adaptation to exercise
    the rights granted to that recipient under the terms of the Applicable
    License; (III) You must keep intact all notices that refer to the
    Applicable License and to the disclaimer of warranties with every copy
    of the Work as included in the Adaptation You Distribute or Publicly
    Perform; (IV) when You Distribute or Publicly Perform the Adaptation,
    You may not impose any effective technological measures on the
    Adaptation that restrict the ability of a recipient of the Adaptation
    from You to exercise the rights granted to that recipient under the
    terms of the Applicable License. This Section 4(b) applies to the
    Adaptation as incorporated in a Collection, but this does not require
    the Collection apart from the Adaptation itself to be made subject to
    the terms of the Applicable License.
 c. If You Distribute, or Publicly Perform the Work or any Adaptations or
    Collections, You must, unless a request has been made pursuant to
    Section 4(a), keep intact all copyright notices for the Work and
    provide, reasonable to the medium or means You are utilizing: (i) the
    name of the Original Author (or pseudonym, if applicable) if supplied,
    and/or if the Original Author and/or Licensor designate another party
    or parties (e.g., a sponsor institute, publishing entity, journal) for
    attribution ("Attribution Parties") in Licensor's copyright notice,
    terms of service or by other reasonable means, the name of such party
    or parties; (ii) the title of the Work if supplied; (iii) to the
    extent reasonably practicable, the URI, if any, that Licensor
    specifies to be associated with the Work, unless such URI does not
    refer to the copyright notice or licensing information for the Work;
    and (iv) , consistent with Ssection 3(b), in the case of an
    Adaptation, a credit identifying the use of the Work in the Adaptation
    (e.g., "French translation of the Work by Original Author," or
    "Screenplay based on original Work by Original Author"). The credit
    required by this Section 4(c) may be implemented in any reasonable
    manner; provided, however, that in the case of a Adaptation or
    Collection, at a minimum such credit will appear, if a credit for all
    contributing authors of the Adaptation or Collection appears, then as
    part of these credits and in a manner at least as prominent as the
    credits for the other contributing authors. For the avoidance of
    doubt, You may only use the credit required by this Section for the
    purpose of attribution in the manner set out above and, by exercising
    Your rights under this License, You may not implicitly or explicitly
    assert or imply any connection with, sponsorship or endorsement by the
    Original Author, Licensor and/or Attribution Parties, as appropriate,
    of You or Your use of the Work, without the separate, express prior
    written permission of the Original Author, Licensor and/or Attribution
    Parties.
 d. Except as otherwise agreed in writing by the Licensor or as may be
    otherwise permitted by applicable law, if You Reproduce, Distribute or
    Publicly Perform the Work either by itself or as part of any
    Adaptations or Collections, You must not distort, mutilate, modify or
    take other derogatory action in relation to the Work which would be
    prejudicial to the Original Author's honor or reputation. Licensor
    agrees that in those jurisdictions (e.g. Japan), in which any exercise
    of the right granted in Section 3(b) of this License (the right to
    make Adaptations) would be deemed to be a distortion, mutilation,
    modification or other derogatory action prejudicial to the Original
    Author's honor and reputation, the Licensor will waive or not assert,
    as appropriate, this Section, to the fullest extent permitted by the
    applicable national law, to enable You to reasonably exercise Your
    right under Section 3(b) of this License (right to make Adaptations)
    but not otherwise.

5. Representations, Warranties and Disclaimer

UNLESS OTHERWISE MUTUALLY AGREED TO BY THE PARTIES IN WRITING, LICENSOR
OFFERS THE WORK AS-IS AND MAKES NO REPRESENTATIONS OR WARRANTIES OF ANY
KIND CONCERNING THE WORK, EXPRESS, IMPLIED, STATUTORY OR OTHERWISE,
INCLUDING, WITHOUT LIMITATION, WARRANTIES OF TITLE, MERCHANTIBILITY,
FITNESS FOR A PARTICULAR PURPOSE, NONINFRINGEMENT, OR THE ABSENCE OF
LATENT OR OTHER DEFECTS, ACCURACY, OR THE PRESENCE OF ABSENCE OF ERRORS,
WHETHER OR NOT DISCOVERABLE. SOME JURISDICTIONS DO NOT ALLOW THE EXCLUSION
OF IMPLIED WARRANTIES, SO SUCH EXCLUSION MAY NOT APPLY TO YOU.

6. Limitation on Liability. EXCEPT TO THE EXTENT REQUIRED BY APPLICABLE
LAW, IN NO EVENT WILL LICENSOR BE LIABLE TO YOU ON ANY LEGAL THEORY FOR
ANY SPECIAL, INCIDENTAL, CONSEQUENTIAL, PUNITIVE OR EXEMPLARY DAMAGES
ARISING OUT OF THIS LICENSE OR THE USE OF THE WORK, EVEN IF LICENSOR HAS
BEEN ADVISED OF THE POSSIBILITY OF SUCH DAMAGES.

7. Termination

 a. This License and the rights granted hereunder will terminate
    automatically upon any breach by You of the terms of this License.
    Individuals or entities who have received Adaptations or Collections
    from You under this License, however, will not have their licenses
    terminated provided such individuals or entities remain in full
    compliance with those licenses. Sections 1, 2, 5, 6, 7, and 8 will
    survive any termination of this License.
 b. Subject to the above terms and conditions, the license granted here is
    perpetual (for the duration of the applicable copyright in the Work).
    Notwithstanding the above, Licensor reserves the right to release the
    Work under different license terms or to stop distributing the Work at
    any time; provided, however that any such election will not serve to
    withdraw this License (or any other license that has been, or is
    required to be, granted under the terms of this License), and this
    License will continue in full force and effect unless terminated as
    stated above.

8. Miscellaneous

 a. Each time You Distribute or Publicly Perform the Work or a Collection,
    the Licensor offers to the recipient a license to the Work on the same
    terms and conditions as the license granted to You under this License.
 b. Each time You Distribute or Publicly Perform an Adaptation, Licensor
    offers to the recipient a license to the original Work on the same
    terms and conditions as the license granted to You under this License.
 c. If any provision of this License is invalid or unenforceable under
    applicable law, it shall not affect the validity or enforceability of
    the remainder of the terms of this License, and without further action
    by the parties to this agreement, such provision shall be reformed to
    the minimum extent necessary to make such provision valid and
    enforceable.
 d. No term or provision of this License shall be deemed waived and no
    breach consented to unless such waiver or consent shall be in writing
    and signed by the party to be charged with such waiver or consent.
 e. This License constitutes the entire agreement between the parties with
    respect to the Work licensed here. There are no understandings,
    agreements or representations with respect to the Work not specified
    here. Licensor shall not be bound by any additional provisions that
    may appear in any communication from You. This License may not be
    modified without the mutual written agreement of the Licensor and You.
 f. The rights granted under, and the subject matter referenced, in this
    License were drafted utilizing the terminology of the Berne Convention
    for the Protection of Literary and Artistic Works (as amended on
    September 28, 1979), the Rome Convention of 1961, the WIPO Copyright
    Treaty of 1996, the WIPO Performances and Phonograms Treaty of 1996
    and the Universal Copyright Convention (as revised on July 24, 1971).
    These rights and subject matter take effect in the relevant
    jurisdiction in which the License terms are sought to be enforced
    according to the corresponding provisions of the implementation of
    those treaty provisions in the applicable national law. If the
    standard suite of rights granted under applicable copyright law
    includes additional rights not granted under this License, such
    additional rights are deemed to be included in the License; this
    License is not intended to restrict the license of any rights under
    applicable law.


Creative Commons Notice

    Creative Commons is not a party to this License, and makes no warranty
    whatsoever in connection with the Work. Creative Commons will not be
    liable to You or any party on any legal theory for any damages
    whatsoever, including without limitation any general, special,
    incidental or consequential damages arising in connection to this
    license. Notwithstanding the foregoing two (2) sentences, if Creative
    Commons has expressly identified itself as the Licensor hereunder, it
    shall have all rights and obligations of Licensor.

    Except for the limited purpose of indicating to the public that the
    Work is licensed under the CCPL, Creative Commons does not authorize
    the use by either party of the trademark "Creative Commons" or any
    related trademark or logo of Creative Commons without the prior
    written consent of Creative Commons. Any permitted use will be in
    compliance with Creative Commons' then-current trademark usage
    guidelines, as may be published on its website or otherwise made
    available upon request from time to time. For the avoidance of doubt,
    this trademark restriction does not form part of the License.

    Creative Commons may be contacted at https://creativecommons.org/.
```

### Playing Cards

```
Creative Commons Legal Code

CC0 1.0 Universal

    CREATIVE COMMONS CORPORATION IS NOT A LAW FIRM AND DOES NOT PROVIDE
    LEGAL SERVICES. DISTRIBUTION OF THIS DOCUMENT DOES NOT CREATE AN
    ATTORNEY-CLIENT RELATIONSHIP. CREATIVE COMMONS PROVIDES THIS
    INFORMATION ON AN "AS-IS" BASIS. CREATIVE COMMONS MAKES NO WARRANTIES
    REGARDING THE USE OF THIS DOCUMENT OR THE INFORMATION OR WORKS
    PROVIDED HEREUNDER, AND DISCLAIMS LIABILITY FOR DAMAGES RESULTING FROM
    THE USE OF THIS DOCUMENT OR THE INFORMATION OR WORKS PROVIDED
    HEREUNDER.

Statement of Purpose

The laws of most jurisdictions throughout the world automatically confer
exclusive Copyright and Related Rights (defined below) upon the creator
and subsequent owner(s) (each and all, an "owner") of an original work of
authorship and/or a database (each, a "Work").

Certain owners wish to permanently relinquish those rights to a Work for
the purpose of contributing to a commons of creative, cultural and
scientific works ("Commons") that the public can reliably and without fear
of later claims of infringement build upon, modify, incorporate in other
works, reuse and redistribute as freely as possible in any form whatsoever
and for any purposes, including without limitation commercial purposes.
These owners may contribute to the Commons to promote the ideal of a free
culture and the further production of creative, cultural and scientific
works, or to gain reputation or greater distribution for their Work in
part through the use and efforts of others.

For these and/or other purposes and motivations, and without any
expectation of additional consideration or compensation, the person
associating CC0 with a Work (the "Affirmer"), to the extent that he or she
is an owner of Copyright and Related Rights in the Work, voluntarily
elects to apply CC0 to the Work and publicly distribute the Work under its
terms, with knowledge of his or her Copyright and Related Rights in the
Work and the meaning and intended legal effect of CC0 on those rights.

1. Copyright and Related Rights. A Work made available under CC0 may be
protected by copyright and related or neighboring rights ("Copyright and
Related Rights"). Copyright and Related Rights include, but are not
limited to, the following:

  i. the right to reproduce, adapt, distribute, perform, display,
     communicate, and translate a Work;
 ii. moral rights retained by the original author(s) and/or performer(s);
iii. publicity and privacy rights pertaining to a person's image or
     likeness depicted in a Work;
 iv. rights protecting against unfair competition in regards to a Work,
     subject to the limitations in paragraph 4(a), below;
  v. rights protecting the extraction, dissemination, use and reuse of data
     in a Work;
 vi. database rights (such as those arising under Directive 96/9/EC of the
     European Parliament and of the Council of 11 March 1996 on the legal
     protection of databases, and under any national implementation
     thereof, including any amended or successor version of such
     directive); and
vii. other similar, equivalent or corresponding rights throughout the
     world based on applicable law or treaty, and any national
     implementations thereof.

2. Waiver. To the greatest extent permitted by, but not in contravention
of, applicable law, Affirmer hereby overtly, fully, permanently,
irrevocably and unconditionally waives, abandons, and surrenders all of
Affirmer's Copyright and Related Rights and associated claims and causes
of action, whether now known or unknown (including existing as well as
future claims and causes of action), in the Work (i) in all territories
worldwide, (ii) for the maximum duration provided by applicable law or
treaty (including future time extensions), (iii) in any current or future
medium and for any number of copies, and (iv) for any purpose whatsoever,
including without limitation commercial, advertising or promotional
purposes (the "Waiver"). Affirmer makes the Waiver for the benefit of each
member of the public at large and to the detriment of Affirmer's heirs and
successors, fully intending that such Waiver shall not be subject to
revocation, rescission, cancellation, termination, or any other legal or
equitable action to disrupt the quiet enjoyment of the Work by the public
as contemplated by Affirmer's express Statement of Purpose.

3. Public License Fallback. Should any part of the Waiver for any reason
be judged legally invalid or ineffective under applicable law, then the
Waiver shall be preserved to the maximum extent permitted taking into
account Affirmer's express Statement of Purpose. In addition, to the
extent the Waiver is so judged Affirmer hereby grants to each affected
person a royalty-free, non transferable, non sublicensable, non exclusive,
irrevocable and unconditional license to exercise Affirmer's Copyright and
Related Rights in the Work (i) in all territories worldwide, (ii) for the
maximum duration provided by applicable law or treaty (including future
time extensions), (iii) in any current or future medium and for any number
of copies, and (iv) for any purpose whatsoever, including without
limitation commercial, advertising or promotional purposes (the
"License"). The License shall be deemed effective as of the date CC0 was
applied by Affirmer to the Work. Should any part of the License for any
reason be judged legally invalid or ineffective under applicable law, such
partial invalidity or ineffectiveness shall not invalidate the remainder
of the License, and in such case Affirmer hereby affirms that he or she
will not (i) exercise any of his or her remaining Copyright and Related
Rights in the Work or (ii) assert any associated claims and causes of
action with respect to the Work, in either case contrary to Affirmer's
express Statement of Purpose.

4. Limitations and Disclaimers.

 a. No trademark or patent rights held by Affirmer are waived, abandoned,
    surrendered, licensed or otherwise affected by this document.
 b. Affirmer offers the Work as-is and makes no representations or
    warranties of any kind concerning the Work, express, implied,
    statutory or otherwise, including without limitation warranties of
    title, merchantability, fitness for a particular purpose, non
    infringement, or the absence of latent or other defects, accuracy, or
    the present or absence of errors, whether or not discoverable, all to
    the greatest extent permissible under applicable law.
 c. Affirmer disclaims responsibility for clearing rights of other persons
    that may apply to the Work or any use thereof, including without
    limitation any person's Copyright and Related Rights in the Work.
    Further, Affirmer disclaims responsibility for obtaining any necessary
    consents, permissions or other rights required for any use of the
    Work.
 d. Affirmer understands and acknowledges that Creative Commons is not a
    party to this document and has no duty or obligation with respect to
    this CC0 or use of the Work.
```