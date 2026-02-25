namespace SoftMasking;

[Token(Token = "0x2000004")]
internal struct ClearListAtExit : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000006")]
	private List<T> _list; //Field offset: 0x0

	[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000003")]
	public ClearListAtExit`1(List<T> list) { }

	[Address(RVA = "0x96C040", Offset = "0x96B240", Length = "0x51")]
	[CalledBy(Type = "SoftMasking.SoftMask+Diagnostics", Member = "PollErrors", ReturnType = typeof(Errors))]
	[CalledBy(Type = "SoftMasking.SoftMask+Diagnostics", Member = "ThereAreNestedMasks", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SoftMask), Member = "SpawnMaskablesInChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "ForEachChildMaskable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<SoftMasking.SoftMaskable>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), "System.Collections.Generic.List`1<T>"}, ReturnType = "T")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000004")]
	public override void Dispose() { }

}

