namespace System.Reflection;

[Flags]
[Token(Token = "0x20004D3")]
public enum GenericParameterAttributes
{
	None = 0,
	VarianceMask = 3,
	Covariant = 1,
	Contravariant = 2,
	SpecialConstraintMask = 28,
	ReferenceTypeConstraint = 4,
	NotNullableValueTypeConstraint = 8,
	DefaultConstructorConstraint = 16,
}

