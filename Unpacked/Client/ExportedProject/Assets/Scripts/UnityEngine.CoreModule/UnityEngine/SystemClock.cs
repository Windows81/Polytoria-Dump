namespace UnityEngine;

[Token(Token = "0x2000180")]
[VisibleToOtherModules]
internal class SystemClock
{
	[Token(Token = "0x40005B5")]
	private static readonly DateTime s_Epoch; //Field offset: 0x0

	[Token(Token = "0x170001BD")]
	public static DateTime now
	{
		[Address(RVA = "0x1970280", Offset = "0x196F480", Length = "0x40")]
		[CalledBy(Type = "UnityEngine.SliderHandler", Member = "OnMouseDown", ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.SliderHandler", Member = "OnRepaint", ReturnType = typeof(float))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[Token(Token = "0x6000ACE")]
		 get { } //Length: 64
	}

	[Address(RVA = "0x1970200", Offset = "0x196F400", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000ACF")]
	private static SystemClock() { }

	[Address(RVA = "0x1970280", Offset = "0x196F480", Length = "0x40")]
	[CalledBy(Type = "UnityEngine.SliderHandler", Member = "OnMouseDown", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.SliderHandler", Member = "OnRepaint", ReturnType = typeof(float))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000ACE")]
	public static DateTime get_now() { }

}

