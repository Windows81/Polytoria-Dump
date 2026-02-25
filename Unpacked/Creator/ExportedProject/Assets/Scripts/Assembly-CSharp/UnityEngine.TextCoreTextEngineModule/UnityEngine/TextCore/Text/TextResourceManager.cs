namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000066")]
internal class TextResourceManager
{
	[Token(Token = "0x2000067")]
	private struct FontAssetRef
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400043C")]
		public int nameHashCode; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400043D")]
		public int familyNameHashCode; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400043E")]
		public int styleNameHashCode; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400043F")]
		public long familyNameAndStyleHashCode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000440")]
		public readonly FontAsset fontAsset; //Field offset: 0x18

		[Address(RVA = "0x18DDF00", Offset = "0x18DD100", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F2")]
		public FontAssetRef(int nameHashCode, int familyNameHashCode, int styleNameHashCode, FontAsset fontAsset) { }

	}

	[Token(Token = "0x4000437")]
	private static readonly Dictionary<Int32, FontAssetRef> s_FontAssetReferences; //Field offset: 0x0
	[Token(Token = "0x4000438")]
	private static readonly Dictionary<Int32, FontAsset> s_FontAssetNameReferenceLookup; //Field offset: 0x8
	[Token(Token = "0x4000439")]
	private static readonly Dictionary<Int64, FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup; //Field offset: 0x10
	[Token(Token = "0x400043A")]
	private static readonly List<Int32> s_FontAssetRemovalList; //Field offset: 0x18
	[Token(Token = "0x400043B")]
	private static readonly int k_RegularStyleHashCode; //Field offset: 0x20

	[Address(RVA = "0x1A6FDC0", Offset = "0x1A6EFC0", Length = "0x26C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002F1")]
	private static TextResourceManager() { }

	[Address(RVA = "0x1A6F750", Offset = "0x1A6E950", Length = "0x663")]
	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FontAsset), Member = "get_familyNameHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int64, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_styleNameHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextAsset), Member = "get_hashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.TextCore.Text.TextResourceManager+FontAssetRef>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(FontAssetRef)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.TextCore.Text.TextResourceManager+FontAssetRef>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(FontAssetRef)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002F0")]
	internal static void AddFontAsset(FontAsset fontAsset) { }

}

