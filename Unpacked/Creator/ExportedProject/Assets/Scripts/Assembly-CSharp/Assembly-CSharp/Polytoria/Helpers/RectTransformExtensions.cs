namespace Polytoria.Helpers;

[Extension]
[Token(Token = "0x200030B")]
public static class RectTransformExtensions
{

	[Address(RVA = "0x417D60", Offset = "0x416F60", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectTransform), Member = "get_offsetMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_offsetMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6001C01")]
	public static RectTransform Bottom(RectTransform rt, float y) { }

	[Address(RVA = "0x417DB0", Offset = "0x416FB0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectTransform), Member = "get_offsetMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_offsetMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6001BFF")]
	public static RectTransform Left(RectTransform rt, float x) { }

	[Address(RVA = "0x417E00", Offset = "0x417000", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectTransform), Member = "get_offsetMax", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_offsetMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6001C00")]
	public static RectTransform Right(RectTransform rt, float x) { }

	[Address(RVA = "0x417E60", Offset = "0x417060", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectTransform), Member = "get_offsetMax", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_offsetMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6001C02")]
	public static RectTransform Top(RectTransform rt, float y) { }

}

