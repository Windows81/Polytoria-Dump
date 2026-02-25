namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
[Token(Token = "0x2000019")]
public sealed class GUIStyleState
{
	[Token(Token = "0x200001A")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000178")]
		public static IntPtr ConvertToNative(GUIStyleState guiStyleState) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000A2")]
	internal IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000A3")]
	private readonly GUIStyle m_SourceStyle; //Field offset: 0x18

	[NativeProperty("textColor", False, TargetType::Field (1))]
	[Token(Token = "0x17000058")]
	public Color textColor
	{
		[Address(RVA = "0x19ABB10", Offset = "0x19AAD10", Length = "0x69")]
		[CalledBy(Type = "LTGUI", Member = "element", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"LTRect", typeof(int)}, ReturnType = "LTRect")]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600016D")]
		 get { } //Length: 105
		[Address(RVA = "0x19ABBD0", Offset = "0x19AADD0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600016E")]
		 set { } //Length: 90
	}

	[Address(RVA = "0x19ABA80", Offset = "0x19AAC80", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000171")]
	public GUIStyleState() { }

	[Address(RVA = "0x193B2B0", Offset = "0x193A4B0", Length = "0x43")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000172")]
	private GUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	[Address(RVA = "0x19AB8D0", Offset = "0x19AAAD0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "GUIStyleState_Bindings::Cleanup", IsThreadSafe = True, HasExplicitThis = True)]
	[Token(Token = "0x6000170")]
	private void Cleanup() { }

	[Address(RVA = "0x19AB890", Offset = "0x19AAA90", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000177")]
	private static void Cleanup_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19AB930", Offset = "0x19AAB30", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000174")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x19ABB10", Offset = "0x19AAD10", Length = "0x69")]
	[CalledBy(Type = "LTGUI", Member = "element", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"LTRect", typeof(int)}, ReturnType = "LTRect")]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600016D")]
	public Color get_textColor() { }

	[Address(RVA = "0x19ABAC0", Offset = "0x19AACC0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000175")]
	private static void get_textColor_Injected(IntPtr _unity_self, out Color ret) { }

	[Address(RVA = "0x19AB9D0", Offset = "0x19AABD0", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000173")]
	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	[Address(RVA = "0x19ABA50", Offset = "0x19AAC50", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "GUIStyleState_Bindings::Init", IsThreadSafe = True)]
	[Token(Token = "0x600016F")]
	private static IntPtr Init() { }

	[Address(RVA = "0x19ABBD0", Offset = "0x19AADD0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600016E")]
	public void set_textColor(Color value) { }

	[Address(RVA = "0x19ABB80", Offset = "0x19AAD80", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000176")]
	private static void set_textColor_Injected(IntPtr _unity_self, in Color value) { }

}

