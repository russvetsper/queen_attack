# _Queen Attack_

#### _Determines if a Queen object can attack a particular coordinate._

#### By _**Russ Vetsper and Andrew Niekamp**_

## Description

_This application takes a user input of two coordinates, and determines through C# logic whether the coordinates are met across vertical, horizontal, or diagonal lines on a given grid._

## Setup/Installation Requirements

_TBD_

## Specifications
| Behavior | Input Example | Output Example |
| ------------- |:-------------:| -----:|
| Generate coordinates | (1,1) , (2,3) | "Coordinates generated" |
| Compare the y values to verify if in same column | 1 == 3 | false |
| Compare the y values to verify if in same column | 1 == 1 | true |
| Compare the x values to verify if in same row | 1 == 2 | false |
| Compare the x values to verify if in same row | 2 == 2 | true |
| Compare the values to verify if in same diagonal line | (1,1) , (2,3) | false |
| Compare the values to verify if in same diagonal line | (1,1) , (3,3) | true |
|  |  |  |
|  |  |  |

## Known Bugs

_None known._

## Support and contact details

_Contact TBD_

## Technologies Used

_C#, Xunit_

### License

*MIT License

*Copyright (c) [2016] Russ Vetsper and Andrew Niekamp*
