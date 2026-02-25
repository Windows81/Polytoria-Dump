namespace UnityEngine;

[NativeHeader("PlatformDependent/iPhonePlayer/IOSScriptBindings.h")]
[Token(Token = "0x2000163")]
internal sealed class UnhandledExceptionHandler
{
	[CompilerGenerated]
	[Token(Token = "0x2000164")]
	private sealed class <>c
	{
		[Token(Token = "0x4000581")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000582")]
		public static UnhandledExceptionEventHandler <>9__0_0; //Field offset: 0x8

		[Address(RVA = "0x1977760", Offset = "0x1976960", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000A0F")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A10")]
		public <>c() { }

		[Address(RVA = "0x19770B0", Offset = "0x19762B0", Length = "0xA4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000A11")]
		internal void <RegisterUECatcher>b__0_0(object sender, UnhandledExceptionEventArgs e) { }

	}


	[Address(RVA = "0x19782A0", Offset = "0x19774A0", Length = "0x114")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AppDomain), Member = "add_UnhandledException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnhandledExceptionEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000A0E")]
	private static void RegisterUECatcher() { }

}

