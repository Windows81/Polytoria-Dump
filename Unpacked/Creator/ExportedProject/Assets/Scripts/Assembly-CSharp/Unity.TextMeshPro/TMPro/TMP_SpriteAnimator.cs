namespace TMPro;

[DisallowMultipleComponent]
[Token(Token = "0x200008A")]
public class TMP_SpriteAnimator : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x200008B")]
	private sealed class <DoSpriteAnimationInternal>d__7 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000484")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000485")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000486")]
		public TMP_SpriteAnimator <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000487")]
		public int start; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000488")]
		public int end; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000489")]
		public TMP_SpriteAsset spriteAsset; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400048A")]
		public int currentCharacter; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x400048B")]
		public int framerate; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400048C")]
		private int <currentFrame>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400048D")]
		private TMP_CharacterInfo <charInfo>5__3; //Field offset: 0x48
		[FieldOffset(Offset = "0x1C0")]
		[Token(Token = "0x400048E")]
		private int <materialIndex>5__4; //Field offset: 0x1C0
		[FieldOffset(Offset = "0x1C4")]
		[Token(Token = "0x400048F")]
		private int <vertexIndex>5__5; //Field offset: 0x1C4
		[FieldOffset(Offset = "0x1C8")]
		[Token(Token = "0x4000490")]
		private TMP_MeshInfo <meshInfo>5__6; //Field offset: 0x1C8
		[FieldOffset(Offset = "0x218")]
		[Token(Token = "0x4000491")]
		private float <baseSpriteScale>5__7; //Field offset: 0x218
		[FieldOffset(Offset = "0x21C")]
		[Token(Token = "0x4000492")]
		private float <elapsedTime>5__8; //Field offset: 0x21C
		[FieldOffset(Offset = "0x220")]
		[Token(Token = "0x4000493")]
		private float <targetTime>5__9; //Field offset: 0x220

		[Token(Token = "0x17000104")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60004A1")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000105")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60004A3")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600049E")]
		public <DoSpriteAnimationInternal>d__7(int <>1__state) { }

		[Address(RVA = "0x18F2280", Offset = "0x18F1480", Length = "0xD1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Mesh), Member = "set_vertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(TMP_SpriteAsset), Member = "UpdateLookupTables", ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
		[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 29)]
		[CallsUnknownMethods(Count = 5)]
		[Token(Token = "0x60004A0")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60004A1")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60004A3")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x18F2FA0", Offset = "0x18F21A0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x60004A2")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600049F")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000482")]
	private Dictionary<Int32, Boolean> m_animations; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000483")]
	private TMP_Text m_TextComponent; //Field offset: 0x28

	[Address(RVA = "0x18EAD70", Offset = "0x18E9F70", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600049D")]
	public TMP_SpriteAnimator() { }

	[Address(RVA = "0x18EAAE0", Offset = "0x18E9CE0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000497")]
	private void Awake() { }

	[Address(RVA = "0x18EABF0", Offset = "0x18E9DF0", Length = "0x122")]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Boolean>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Boolean>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600049B")]
	public void DoSpriteAnimation(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate) { }

	[Address(RVA = "0x18EAB30", Offset = "0x18E9D30", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<DoSpriteAnimationInternal>d__7))]
	[Token(Token = "0x600049C")]
	private IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000499")]
	private void OnDisable() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000498")]
	private void OnEnable() { }

	[Address(RVA = "0x18EAD20", Offset = "0x18E9F20", Length = "0x4E")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopAllCoroutines", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600049A")]
	public void StopAllAnimations() { }

}

