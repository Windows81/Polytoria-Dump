namespace System;

[Token(Token = "0x20001CD")]
internal class TypeNames
{
	[Token(Token = "0x20001CE")]
	public abstract class ATypeName : TypeName, IEquatable<TypeName>
	{

		[Token(Token = "0x17000176")]
		public abstract string DisplayName
		{
			[Token(Token = "0x6001029")]
			 get { } //Length: 0
		}

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600102D")]
		protected ATypeName() { }

		[Address(RVA = "0x1508680", Offset = "0x1507880", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600102A")]
		public override bool Equals(TypeName other) { }

		[Address(RVA = "0x1508700", Offset = "0x1507900", Length = "0xBD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600102C")]
		public virtual bool Equals(object other) { }

		[Token(Token = "0x6001029")]
		public abstract string get_DisplayName() { }

		[Address(RVA = "0x15087C0", Offset = "0x15079C0", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600102B")]
		public virtual int GetHashCode() { }

	}


}

