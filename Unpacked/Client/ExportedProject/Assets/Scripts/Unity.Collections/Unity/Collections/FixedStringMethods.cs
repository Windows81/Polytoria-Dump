namespace Unity.Collections;

[Extension]
[GenerateTestsForBurstCompatibility]
[GenerateTestsForBurstCompatibility]
[GenerateTestsForBurstCompatibility]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x200001B")]
public static class FixedStringMethods
{

	[Address(RVA = "0x6B3710", Offset = "0x6B2910", Length = "0x108")]
	[CalledBy(Type = typeof(UnsafeText), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180698310")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(Unicode), Member = "Utf8ToUtf16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Returns managed string")]
	[Extension]
	[Token(Token = "0x600003F")]
	public static string ConvertToString(ref T fs) { }

}

