/* 
When writing code, sometimes we want to tell the computer
to make use of "And", "Or".
Typically we use these conditionals in Else if statements. 
 */

//Here Is an Example of how to write And
if (a && b)

//Here is example of Or
if (a || b)

/* When using And, it takes both variables and only 
runs a certain bit of code if both conditions are met.
This is great for applying keys for gameplay
*/

//This code would make the player have to press Left shift and W on
//The Keyboarda the same thime to shift
if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey(KeyCode.W)))

//This code would would let you press W or the up button to move forward
if (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.UpArrow)))