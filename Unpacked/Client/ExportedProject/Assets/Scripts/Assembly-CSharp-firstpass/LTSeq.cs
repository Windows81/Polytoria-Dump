//Type is in global namespace

[Token(Token = "0x2000022")]
public class LTSeq
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000146")]
	public LTSeq previous; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000147")]
	public LTSeq current; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000148")]
	public LTDescr tween; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000149")]
	public float totalDelay; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400014A")]
	public float timeScale; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400014B")]
	private int debugIter; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400014C")]
	public uint counter; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400014D")]
	public bool toggle; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400014E")]
	private uint _id; //Field offset: 0x3C

	[Token(Token = "0x17000030")]
	public int id
	{
		[Address(RVA = "0x2F2260", Offset = "0x2F1460", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000350")]
		 get { } //Length: 10
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600035F")]
	public LTSeq() { }

	[Address(RVA = "0x2F1C90", Offset = "0x2F0E90", Length = "0xC3")]
	[CalledBy(Type = typeof(LTSeq), Member = "append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(LTSeq))]
	[CalledBy(Type = typeof(LTSeq), Member = "append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object)}, ReturnType = typeof(LTSeq))]
	[CalledBy(Type = typeof(LTSeq), Member = "append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Action)}, ReturnType = typeof(LTSeq))]
	[CalledBy(Type = typeof(LTSeq), Member = "append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(System.Action`1<System.Object>), typeof(object)}, ReturnType = typeof(LTSeq))]
	[CalledBy(Type = typeof(LTSeq), Member = "append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LTDescr)}, ReturnType = typeof(LTSeq))]
	[CalledBy(Type = typeof(LTSeq), Member = "insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LTDescr)}, ReturnType = typeof(LTSeq))]
	[CalledBy(Type = typeof(LTSeq), Member = "setScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(LTSeq))]
	[CalledBy(Type = typeof(LTSeq), Member = "reverse", ReturnType = typeof(LTSeq))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "sequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(LTSeq))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000353")]
	private LTSeq addOn() { }

	[Address(RVA = "0x2F1D60", Offset = "0x2F0F60", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000354")]
	private float addPreviousDelays() { }

	[Address(RVA = "0x2F20D0", Offset = "0x2F12D0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000355")]
	public LTSeq append(float delay) { }

	[Address(RVA = "0x2F2190", Offset = "0x2F1390", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "delayedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Action)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LTSeq), Member = "addOn", ReturnType = typeof(LTSeq))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000356")]
	public LTSeq append(Action callback) { }

	[Address(RVA = "0x2F1DB0", Offset = "0x2F0FB0", Length = "0x10C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "delayedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(System.Action`1<System.Object>)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LTSeq), Member = "addOn", ReturnType = typeof(LTSeq))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000357")]
	public LTSeq append(Action<Object> callback, object obj) { }

	[Address(RVA = "0x2F1FE0", Offset = "0x2F11E0", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "delayedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(Action)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LTSeq), Member = "addOn", ReturnType = typeof(LTSeq))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000358")]
	public LTSeq append(GameObject gameObject, Action callback) { }

	[Address(RVA = "0x2F1EC0", Offset = "0x2F10C0", Length = "0x11C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LeanTween), Member = "delayedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(float), typeof(System.Action`1<System.Object>)}, ReturnType = typeof(LTDescr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LTSeq), Member = "addOn", ReturnType = typeof(LTSeq))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000359")]
	public LTSeq append(GameObject gameObject, Action<Object> callback, object obj) { }

	[Address(RVA = "0x2F2100", Offset = "0x2F1300", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LTSeq), Member = "addOn", ReturnType = typeof(LTSeq))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600035A")]
	public LTSeq append(LTDescr tween) { }

	[Address(RVA = "0x2F2260", Offset = "0x2F1460", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000350")]
	public int get_id() { }

	[Address(RVA = "0x2F2270", Offset = "0x2F1470", Length = "0x69")]
	[CalledBy(Type = typeof(LeanTween), Member = "sequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(LTSeq))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000352")]
	public void init(uint id, uint global_counter) { }

	[Address(RVA = "0x2F22E0", Offset = "0x2F14E0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LTSeq), Member = "addOn", ReturnType = typeof(LTSeq))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600035B")]
	public LTSeq insert(LTDescr tween) { }

	[Address(RVA = "0x2F2360", Offset = "0x2F1560", Length = "0x3C")]
	[CalledBy(Type = typeof(LeanTween), Member = "sequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(LTSeq))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000351")]
	public void reset() { }

	[Address(RVA = "0x2F23A0", Offset = "0x2F15A0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LTSeq), Member = "addOn", ReturnType = typeof(LTSeq))]
	[Token(Token = "0x600035E")]
	public LTSeq reverse() { }

	[Address(RVA = "0x2F2440", Offset = "0x2F1640", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LTSeq), Member = "setScaleRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LTSeq), typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LTSeq), Member = "addOn", ReturnType = typeof(LTSeq))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600035C")]
	public LTSeq setScale(float timeScale) { }

	[Address(RVA = "0x2F23B0", Offset = "0x2F15B0", Length = "0x8C")]
	[CalledBy(Type = typeof(LTSeq), Member = "setScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(LTSeq))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600035D")]
	private void setScaleRecursive(LTSeq seq, float timeScale, int count) { }

}

