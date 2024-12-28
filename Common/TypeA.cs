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

    internal class TypeA
    {

        void Fun01()
        {
            TypeA typeA = new TypeA();

            TypeA typeB = new TypeB(); // Valied
        }

        public static implicit operator TypeA(TypeB v)
        {
            throw new NotImplementedException();
        }
    }
}
