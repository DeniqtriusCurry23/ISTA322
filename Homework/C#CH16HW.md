# Discussion Questions C# CH16
## Deniqtrius Curry
#date: April 10,2018

1. Five examples of bitwise operators are: Not ~, left-shift <<, or |, and &, xor ^.  

2. there is right shift. 4 >> 2 is 00000001.  

3. Here 'bits' is an eight bit integer, and index is an integer. The binary number 1 (00000001) 
is shifted 'index' numbers to the left. The result of this shift is ANDed with the eight bit 
number 'bits' and the result is eight bit integer with ones in the indexes that both numbers share. 

4. Again the number 00000001 is shifted 'index' spots left, and where the result of this and 
'bits' share 1's the result. Pretty much adds the one to the position of index.  

5. That code sets the value of bits to all 0's except for a 1 in the position shifted index 
numbers to the left. 

6. C# sets the boolean 'peek' to true if the value at the position n of the integer bits is one, 
and false otherwise.  

7. C# sets the value at the index position of n of bits to 1.  

8. C# sets the bit at index n to 0 if its 1 and 1 if its 0.  

9. a neither read nor write nor execute
	b read only
	c write only
	d read and write only
	e execute only
	f execute and read only
	g execute and write only
	h read write and execute
	
10. 	a 000
		b 001
		c 010
		d 011
		e 100
		f 101
		g 110
		h 111
		
	It tells me that you can set any combination of three permissions using only 
	three bits and therefore its much more efficient way of using permissions.