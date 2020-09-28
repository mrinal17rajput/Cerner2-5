<?php 
// cerner_2^5_2020
// A PHP program to find floor(sqrt(x) 
  
// Returns floor of square root of x 
function floorSqrt($x) 
{ 
    // Base cases 
    if ($x == 0 || $x == 1) 
    return $x; 
  
    // Staring from 1, try all  
    // numbers until i*i is  
    // greater than or equal to x. 
    $i = 1; 
    $result = 1; 
    while ($result <= $x) 
    { 
        $i++; 
        $result = $i * $i; 
    } 
    return $i - 1; 
} 
  
// Driver Code 
$x = 11; 
echo floorSqrt($x), "\n";