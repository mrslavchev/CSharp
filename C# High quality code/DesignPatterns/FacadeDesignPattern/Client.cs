using System;
using Library;


class Client
{
    static void Main()
    {
        Facade.Operation1();
        Facade.Operation2();
    }
}/* Output

 Operation 1
 Subsystem A, Method A1
 Subsystem A, Method A2
 Subsystem B, Method B1

 Operation 2
 Subsystem B, Method B1
 Subsystem C, Method C1
 */