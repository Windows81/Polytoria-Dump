namespace UnityEngine;

[RequiredByNativeCode]
[Token(Token = "0x200000A")]
internal struct AnimationEventBlittable : IDisposable
{
	[ThreadStatic]
	[Token(Token = "0x4000015")]
	private static GCHandlePool s_handlePool; //Field offset: 0x80000000
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000A")]
	internal float m_Time; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400000B")]
	internal IntPtr m_FunctionName; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000C")]
	internal IntPtr m_StringParameter; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400000D")]
	internal IntPtr m_ObjectReferenceParameter; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400000E")]
	internal float m_FloatParameter; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400000F")]
	internal int m_IntParameter; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000010")]
	internal int m_MessageOptions; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000011")]
	internal AnimationEventSource m_Source; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000012")]
	internal IntPtr m_StateSender; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000013")]
	internal AnimatorStateInfo m_AnimatorStateInfo; //Field offset: 0x38
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000014")]
	internal AnimatorClipInfo m_AnimatorClipInfo; //Field offset: 0x5C

	[Address(RVA = "0x1911C60", Offset = "0x1910E60", Length = "0x15A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GCHandlePool), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GCHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000041")]
	public override void Dispose() { }

	[Address(RVA = "0x1911DC0", Offset = "0x1910FC0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationEventBlittable), Member = "ToAnimationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationEventBlittable)}, ReturnType = typeof(AnimationEvent))]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x600003F")]
	internal static AnimationEvent PointerToAnimationEvent(IntPtr animationEventBlittable) { }

	[Address(RVA = "0x1911E30", Offset = "0x1911030", Length = "0x4C9")]
	[CalledBy(Type = typeof(AnimationEventBlittable), Member = "PointerToAnimationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(AnimationEvent))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18038DB40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000040")]
	internal static AnimationEvent ToAnimationEvent(AnimationEventBlittable animationEventBlittable) { }

}

