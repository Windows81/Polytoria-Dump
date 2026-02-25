namespace UnityEngine;

[NativeHeader("Modules/Animation/AnimationState.h")]
[Token(Token = "0x2000008")]
[UsedByNativeCode]
public sealed class AnimationState : TrackedReference
{
	[Token(Token = "0x2000009")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600003E")]
		public static IntPtr ConvertToNative(AnimationState animationState) { }

	}


	[Token(Token = "0x17000008")]
	public AnimationClip clip
	{
		[Address(RVA = "0x1913720", Offset = "0x1912920", Length = "0x84")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B5340")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000036")]
		 get { } //Length: 132
	}

	[Token(Token = "0x17000007")]
	public float length
	{
		[Address(RVA = "0x19137F0", Offset = "0x19129F0", Length = "0x51")]
		[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "GetAnimationInfo", ReturnType = "Polytoria.Datamodel.AnimationInfo[]")]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000035")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000009")]
	public string name
	{
		[Address(RVA = "0x19138A0", Offset = "0x1912AA0", Length = "0xCE")]
		[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "RefreshAnimationComponents", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000037")]
		 get { } //Length: 206
	}

	[Token(Token = "0x17000006")]
	public float speed
	{
		[Address(RVA = "0x19139C0", Offset = "0x1912BC0", Length = "0x61")]
		[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "PlayAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000034")]
		 set { } //Length: 97
	}

	[Token(Token = "0x17000005")]
	public WrapMode wrapMode
	{
		[Address(RVA = "0x1913A70", Offset = "0x1912C70", Length = "0x58")]
		[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "PlayAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000033")]
		 set { } //Length: 88
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000038")]
	public AnimationState() { }

	[Address(RVA = "0x1913720", Offset = "0x1912920", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B5340")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000036")]
	public AnimationClip get_clip() { }

	[Address(RVA = "0x19136E0", Offset = "0x19128E0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003C")]
	private static IntPtr get_clip_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19137F0", Offset = "0x19129F0", Length = "0x51")]
	[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "GetAnimationInfo", ReturnType = "Polytoria.Datamodel.AnimationInfo[]")]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000035")]
	public float get_length() { }

	[Address(RVA = "0x19137B0", Offset = "0x19129B0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003B")]
	private static float get_length_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19138A0", Offset = "0x1912AA0", Length = "0xCE")]
	[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "RefreshAnimationComponents", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000037")]
	public string get_name() { }

	[Address(RVA = "0x1913850", Offset = "0x1912A50", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003D")]
	private static void get_name_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x19139C0", Offset = "0x1912BC0", Length = "0x61")]
	[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "PlayAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000034")]
	public void set_speed(float value) { }

	[Address(RVA = "0x1913970", Offset = "0x1912B70", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003A")]
	private static void set_speed_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x1913A70", Offset = "0x1912C70", Length = "0x58")]
	[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "PlayAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000033")]
	public void set_wrapMode(WrapMode value) { }

	[Address(RVA = "0x1913A30", Offset = "0x1912C30", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000039")]
	private static void set_wrapMode_Injected(IntPtr _unity_self, WrapMode value) { }

}

