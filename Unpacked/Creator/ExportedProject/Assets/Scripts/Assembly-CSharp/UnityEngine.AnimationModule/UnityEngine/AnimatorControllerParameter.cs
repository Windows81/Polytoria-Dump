namespace UnityEngine;

[NativeAsStruct]
[NativeHeader("Modules/Animation/AnimatorControllerParameter.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
[NativeType(CodegenOptions::Custom (1), "MonoAnimatorControllerParameter")]
[Token(Token = "0x2000014")]
[UsedByNativeCode]
public class AnimatorControllerParameter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000040")]
	internal string m_Name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000041")]
	internal AnimatorControllerParameterType m_Type; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000042")]
	internal float m_DefaultFloat; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000043")]
	internal int m_DefaultInt; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000044")]
	internal bool m_DefaultBool; //Field offset: 0x24

	[Token(Token = "0x17000013")]
	public string name
	{
		[Address(RVA = "0xC4A010", Offset = "0xC49210", Length = "0x7")]
		[CallerCount(Count = 196)]
		[DeduplicatedMethod]
		[Token(Token = "0x600009D")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000014")]
	public int nameHash
	{
		[Address(RVA = "0x1914CC0", Offset = "0x1913EC0", Length = "0xD")]
		[CalledBy(Type = "Mirror.NetworkAnimator", Member = "NextDirtyBits", ReturnType = typeof(ulong))]
		[CalledBy(Type = "Mirror.NetworkAnimator", Member = "WriteParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkWriter", typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Mirror.NetworkAnimator", Member = "ReadParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkReader"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkAnimator", Member = "<Initialize>b__14_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimatorControllerParameter)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(Animator), Member = "StringToHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Token(Token = "0x600009E")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000015")]
	public AnimatorControllerParameterType type
	{
		[Address(RVA = "0x8520C0", Offset = "0x8512C0", Length = "0x6")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x600009F")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1914C70", Offset = "0x1913E70", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000A2")]
	public AnimatorControllerParameter() { }

	[Address(RVA = "0x1914BC0", Offset = "0x1913DC0", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000A0")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0xC4A010", Offset = "0xC49210", Length = "0x7")]
	[CallerCount(Count = 196)]
	[DeduplicatedMethod]
	[Token(Token = "0x600009D")]
	public string get_name() { }

	[Address(RVA = "0x1914CC0", Offset = "0x1913EC0", Length = "0xD")]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "NextDirtyBits", ReturnType = typeof(ulong))]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "WriteParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkWriter", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "ReadParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkReader"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "<Initialize>b__14_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimatorControllerParameter)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Animator), Member = "StringToHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Token(Token = "0x600009E")]
	public int get_nameHash() { }

	[Address(RVA = "0x8520C0", Offset = "0x8512C0", Length = "0x6")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x600009F")]
	public AnimatorControllerParameterType get_type() { }

	[Address(RVA = "0x300BF0", Offset = "0x2FFDF0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A1")]
	public virtual int GetHashCode() { }

}

