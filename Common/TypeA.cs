using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    // Access Modifiers: C# Keywords Indicate Accessibility Scope
    // 1. private
    // 2. private protected
    // 3. protected
    // 4. internal
    // 5. internal protected
    // 6. public



    // What Can Write Inside The Namespace?
    // 1. Class
    // 2. Struct
    // 3. Interface
    // 4. Enum

    // Access Modifiers Inside The Namespace:
    // 1. internal  : Inside The Same Project
    // 2. Public    : Everywher

    // Default Access Modifier Inside The Namespace "Internal"

    // What Can Write Inside The Class Or Struct?
    // 1. Attributes [Filed Member Variable]
    // 2. Properties [Full Property - Automatic Property - Special Property]
    //3. Methods-Functions
    // 4. Event

    // Access Modifiers Inside The Class:

    // 1. private
    // 2. private protected
    // 3. protected
    // 4. internal
    //5. internal protected
    // 6. public

    // Access Modifiers Inside The Struct:
    // 1. private   : Inside The Same Class
    // 2. internal  : Inside The Same Project
    // 3. public    : Everywhere

    // Default Access Modifier Inside The class Or Struct "Private"

    // What Can Write Inside The Interface?
    // 1. Signature Of Methods [Return - Type Name - Parameter]
    // 2. Signature Of Property
    // 3. Default Implemented Methods [C# 8.0.NET Core 3.1]

    // All Access Modifiers Except "private"

    // Default Access Modifier Inside The Interface "public"


    internal class TypeA
    {
        Void Fun01()
        {
            TypeA typeA = new TypeA();

            TypeA typeB = new TypeB(); // Valied

            //tybeB.X = 12; // Invalid: Private
            typeB.Y = 12; // valid
            typeB.Z = 12; // valid
        }
    }
}
