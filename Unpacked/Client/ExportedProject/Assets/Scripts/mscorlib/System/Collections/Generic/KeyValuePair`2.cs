namespace System.Collections.Generic;

[IsReadOnly]
[Token(Token = "0x20005E3")]
public struct KeyValuePair
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001858")]
	private readonly TKey key; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001859")]
	private readonly TValue value; //Field offset: 0x0

	[Token(Token = "0x170006C4")]
	public TKey Key
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B18")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170006C5")]
	public TValue Value
	{
		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B19")]
		 get { } //Length: 4
	}

	[Address(RVA = "0xCE3150", Offset = "0xCE2350", Length = "0x8")]
	[CallerCount(Count = 311)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B17")]
	public KeyValuePair`2(TKey key, TValue value) { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B18")]
	public TKey get_Key() { }

	[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B19")]
	public TValue get_Value() { }

	[Address(RVA = "0xCE2450", Offset = "0xCE1650", Length = "0xBC")]
	[CalledBy(Type = "UnityEngine.EventSystems.TouchInputModule", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "GLTFast.GltfImportBase+<LoadAccessorData>d__140", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(KeyValuePair), Member = "PairToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B1A")]
	public virtual string ToString() { }

}

