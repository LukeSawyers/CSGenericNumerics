# C# Generic Numerics
## Summary
This is a library of numeric types for C# that implements a common type between all number types. This permits polymorphsim between all supported number types as well as the use of generic constraints to restrict type arguments to number types. 

This has been realized previously by some using dynamic types, but you'll find no dynamics here!

All numeric types overload all relevant Unary and Binary operators. Maths works just as it would with normal types

Also includes:
* BitConverter implementation for the base Numeric type
* Implicit string casting to all Numeric Types

## Usage
Assign your built in number values to Explicitly typed Numeric, or cast the value and you're good to go:

```cs
Int32T valueOne = 42
var valueTwo = (Int32T)42.14159
```

Use the base Numeric type as the constraint for a generic type and you'll be able to use number operators with the variables you use that type for:

```cs
class CanUseWithAnyNumber<TNumeric> where TNumeric : Numeric
{
    TNumeric _heldValue;
    
    public void AddToHeldValue(TNumeric valueToAdd)
    {
        _heldValue += valueToAdd;
    }
}
```

## Notes
By necessity the base Numeric classes are left exposed and may be derived and used to include non-number types. You can have a crack at this if you like, but just because you can do it doesnt mean you necessarily should do it!

## More to come:
* Equals and GetHash overloads
* Better documentation of usage
* 100% line and mutation test coverage
* Example project using both standard types and Numeric Types
