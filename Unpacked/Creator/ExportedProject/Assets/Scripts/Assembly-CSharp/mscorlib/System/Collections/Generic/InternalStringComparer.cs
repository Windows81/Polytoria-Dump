namespace System.Collections.Generic;

[Token(Token = "0x2000607")]
internal sealed class InternalStringComparer : EqualityComparer<String>
{

	[Address(RVA = "0x1444C60", Offset = "0x1443E60", Length = "0x39")]
	[CalledBy(Type = typeof(EqualityComparer`1), Member = "CreateComparer", ReturnType = "System.Collections.Generic.EqualityComparer`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002C3F")]
	public InternalStringComparer() { }

	[Address(RVA = "0x1444BA0", Offset = "0x1443DA0", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002C3D")]
	public virtual bool Equals(string x, string y) { }

	[Address(RVA = "0xC52BB0", Offset = "0xC51DB0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C3C")]
	public virtual int GetHashCode(string obj) { }

	[Address(RVA = "0x1444BD0", Offset = "0x1443DD0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002C3E")]
	internal virtual int IndexOf(String[] array, string value, int startIndex, int count) { }

}

