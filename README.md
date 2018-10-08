
trafficAlgorithm.cs

//Footnote #1 for computer science programmers: This class contains one public function of type static.  When a function is
//is classified as 'static' then the caller function can call this static function without creating an object of type
//Clock_algorithm.  If the function is not static then the caller must create an object of type Clock_algorithms and then
//call set_up_screen_delay as a member of the object.  In summary the ability to create 'static' functions is a good thing.
//Static function are more simple to call.



//Footnote #2 for computer science programmers: See how "pass by reference" is done in C#.  The concept is the same as pass by
//reference in C++, but the implementation is written somewhat differently in C#.



trafficFrame.cs

    //Students: Sometimes it is critical to select the initial elapse time in consideration with other times in the system.
    //In this case the initial delay must be sufficiently large to allow initialization processes to complete.
    //To experience the problem simply change the initial clock delay from the current value to a smaller value, then the 
    //output sequence is wrong for the first few output screens.  Eventually the software will get the sequence correct.