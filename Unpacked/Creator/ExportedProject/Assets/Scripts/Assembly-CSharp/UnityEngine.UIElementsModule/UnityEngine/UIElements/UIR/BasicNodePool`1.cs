namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000575")]
internal class BasicNodePool : LinkedPool<BasicNode`1<T>>
{

	[Address(RVA = "0x963830", Offset = "0x962A30", Length = "0xE7")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LinkedPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002709")]
	public BasicNodePool`1() { }

	[Address(RVA = "0x963620", Offset = "0x962820", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002708")]
	private static BasicNode<T> Create() { }

	[Address(RVA = "0x9637B0", Offset = "0x9629B0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002707")]
	private static void Reset(BasicNode<T> node) { }

}

