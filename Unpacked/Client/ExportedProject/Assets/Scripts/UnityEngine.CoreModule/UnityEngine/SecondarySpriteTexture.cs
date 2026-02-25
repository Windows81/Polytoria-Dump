namespace UnityEngine;

[Token(Token = "0x2000069")]
public struct SecondarySpriteTexture : IEquatable<SecondarySpriteTexture>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000D0")]
	public string name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000D1")]
	public Texture2D texture; //Field offset: 0x8

	[Address(RVA = "0x193E520", Offset = "0x193D720", Length = "0x48")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000106")]
	public override bool Equals(SecondarySpriteTexture other) { }

	[Address(RVA = "0x193E570", Offset = "0x193D770", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000107")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x193E620", Offset = "0x193D820", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000108")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x193E520", Offset = "0x193D720", Length = "0x48")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000109")]
	public static bool op_Equality(SecondarySpriteTexture lhs, SecondarySpriteTexture rhs) { }

	[Address(RVA = "0x193E690", Offset = "0x193D890", Length = "0x4C")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "CheckSecondaryTexturesChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), "UnityEngine.SecondarySpriteTexture[]&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "<CheckSecondaryTexturesChanged>g__Compare|93_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.SecondarySpriteTexture[]", "UnityEngine.SecondarySpriteTexture[]"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600010A")]
	public static bool op_Inequality(SecondarySpriteTexture lhs, SecondarySpriteTexture rhs) { }

}

