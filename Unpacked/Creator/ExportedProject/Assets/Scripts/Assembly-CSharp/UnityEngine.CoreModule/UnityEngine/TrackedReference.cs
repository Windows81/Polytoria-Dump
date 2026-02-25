namespace UnityEngine;

[Token(Token = "0x2000162")]
[UsedByNativeCode]
public class TrackedReference
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000580")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.AnimationModule"})]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A08")]
	protected TrackedReference() { }

	[Address(RVA = "0x1972CD0", Offset = "0x1971ED0", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A0B")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x1972DA0", Offset = "0x1971FA0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A0C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1972DB0", Offset = "0x1971FB0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A09")]
	public static bool op_Equality(TrackedReference x, TrackedReference y) { }

	[Address(RVA = "0x1972E00", Offset = "0x1972000", Length = "0x11")]
	[CalledBy(Type = "UnityEngine.Animation", Member = "GetClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.AnimationClip")]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A0D")]
	public static bool op_Implicit(TrackedReference exists) { }

	[Address(RVA = "0x1972E20", Offset = "0x1972020", Length = "0x4B")]
	[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "PlayAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "GetAnimationInfo", ReturnType = "Polytoria.Datamodel.AnimationInfo[]")]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A0A")]
	public static bool op_Inequality(TrackedReference x, TrackedReference y) { }

}

