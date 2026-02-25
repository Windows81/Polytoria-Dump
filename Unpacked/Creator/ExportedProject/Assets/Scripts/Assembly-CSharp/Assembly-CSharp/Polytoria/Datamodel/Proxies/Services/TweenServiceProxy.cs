namespace Polytoria.Datamodel.Proxies.Services;

[Token(Token = "0x20003DC")]
public class TweenServiceProxy
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001027")]
	private readonly TweenService tweenService; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60029D7")]
	public TweenServiceProxy(TweenService target) { }

	[Address(RVA = "0x4AD210", Offset = "0x4AC410", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "cancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60029DF")]
	public static void Cancel(int id, bool callOnComplete = false) { }

	[Address(RVA = "0x4AD1C0", Offset = "0x4AC3C0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "cancelAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60029E0")]
	public static void CancelAll(bool callOnComplete = false) { }

	[Address(RVA = "0x4AD270", Offset = "0x4AC470", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "isPaused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x60029E3")]
	public static bool IsPaused(int id) { }

	[Address(RVA = "0x4AD2C0", Offset = "0x4AC4C0", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "pause", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60029E1")]
	public static void Pause(int id) { }

	[Address(RVA = "0x4AD310", Offset = "0x4AC510", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "resume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60029E2")]
	public static void Resume(int id) { }

	[Address(RVA = "0x4AD360", Offset = "0x4AC560", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenService), Member = "TweenColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color), typeof(float), typeof(DynValue), typeof(LeanTweenType), typeof(DynValue)}, ReturnType = typeof(int))]
	[LuaCallbackParameter("callback", typeof(Color), "value", False)]
	[Token(Token = "0x60029DC")]
	public static int TweenColor(Color start, Color end, float time, DynValue callback, LeanTweenType tweenType = 1, DynValue callOnComplete = null) { }

	[Address(RVA = "0x4AD3B0", Offset = "0x4AC5B0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenService), Member = "TweenNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(DynValue), typeof(LeanTweenType), typeof(DynValue)}, ReturnType = typeof(int))]
	[LuaCallbackParameter("callback", typeof(float), "value", False)]
	[Token(Token = "0x60029DB")]
	public static int TweenNumber(float start, float end, float time, DynValue callback, LeanTweenType tweenType = 1, DynValue callOnComplete = null) { }

	[Address(RVA = "0x4AD3C0", Offset = "0x4AC5C0", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenService), Member = "TweenPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicInstance), typeof(Vector3), typeof(float), typeof(LeanTweenType), typeof(DynValue)}, ReturnType = typeof(int))]
	[Token(Token = "0x60029D8")]
	public static int TweenPosition(DynamicInstance target, Vector3 destination, float time, LeanTweenType tweenType = 1, DynValue callOnComplete = null) { }

	[Address(RVA = "0x4AD400", Offset = "0x4AC600", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenService), Member = "TweenRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicInstance), typeof(Vector3), typeof(float), typeof(LeanTweenType), typeof(DynValue)}, ReturnType = typeof(int))]
	[Token(Token = "0x60029D9")]
	public static int TweenRotation(DynamicInstance target, Vector3 destination, float time, LeanTweenType tweenType = 1, DynValue callOnComplete = null) { }

	[Address(RVA = "0x4AD440", Offset = "0x4AC640", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenService), Member = "TweenSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicInstance), typeof(Vector3), typeof(float), typeof(LeanTweenType), typeof(DynValue)}, ReturnType = typeof(int))]
	[Token(Token = "0x60029DA")]
	public static int TweenSize(DynamicInstance target, Vector3 destination, float time, LeanTweenType tweenType = 1, DynValue callOnComplete = null) { }

	[Address(RVA = "0x4AD480", Offset = "0x4AC680", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenService), Member = "TweenVector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float), typeof(DynValue), typeof(LeanTweenType), typeof(DynValue)}, ReturnType = typeof(int))]
	[LuaCallbackParameter("callback", typeof(Vector2), "value", False)]
	[Token(Token = "0x60029DE")]
	public static int TweenVector2(Vector2 start, Vector2 end, float time, DynValue callback, LeanTweenType tweenType = 1, DynValue callOnComplete = null) { }

	[Address(RVA = "0x4AD490", Offset = "0x4AC690", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenService), Member = "TweenVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(DynValue), typeof(LeanTweenType), typeof(DynValue)}, ReturnType = typeof(int))]
	[LuaCallbackParameter("callback", typeof(Vector3), "value", False)]
	[Token(Token = "0x60029DD")]
	public static int TweenVector3(Vector3 start, Vector3 end, float time, DynValue callback, LeanTweenType tweenType = 1, DynValue callOnComplete = null) { }

}

