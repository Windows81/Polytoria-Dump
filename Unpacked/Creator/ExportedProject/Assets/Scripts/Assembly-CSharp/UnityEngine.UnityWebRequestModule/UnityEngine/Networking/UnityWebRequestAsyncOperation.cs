namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequestAsyncOperation.h")]
[NativeHeader("UnityWebRequestScriptingClasses.h")]
[Token(Token = "0x200000A")]
[UsedByNativeCode]
public class UnityWebRequestAsyncOperation : AsyncOperation
{
	[Token(Token = "0x200000B")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x1CF79C0", Offset = "0x1CF6BC0", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(AsyncOperation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000044")]
		public static UnityWebRequestAsyncOperation ConvertToManaged(IntPtr ptr) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400001C")]
	private UnityWebRequest <webRequest>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000006")]
	internal UnityWebRequest webRequest
	{
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000043")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x1CF8610", Offset = "0x1CF7810", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOperation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000042")]
	private UnityWebRequestAsyncOperation(IntPtr ptr) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000043")]
	internal void set_webRequest(UnityWebRequest value) { }

}

