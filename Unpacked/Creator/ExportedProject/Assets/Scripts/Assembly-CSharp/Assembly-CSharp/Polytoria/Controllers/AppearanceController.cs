namespace Polytoria.Controllers;

[Token(Token = "0x20003ED")]
public class AppearanceController : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x20003EE")]
	private sealed class <>c__DisplayClass8_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400104F")]
		public Transform headObj; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001050")]
		public Transform leftArmObj; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001051")]
		public Transform rightArmObj; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001052")]
		public Transform torsoObj; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001053")]
		public Transform leftLegObj; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4001054")]
		public Transform rightLegObj; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4001055")]
		public Action<ImageCacheKey, ImageCacheEntry> <>9__0; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4001056")]
		public Action<ImageCacheKey, ImageCacheEntry> <>9__1; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4001057")]
		public Action<ImageCacheKey, ImageCacheEntry> <>9__2; //Field offset: 0x50

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A3B")]
		public <>c__DisplayClass8_0() { }

		[Address(RVA = "0x4B5240", Offset = "0x4B4440", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Texture), Member = "set_wrapMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureWrapMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Material), Member = "set_mainTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002A3C")]
		internal void <ProcessPlayerAppearance>b__0(ImageCacheKey key, ImageCacheEntry entry) { }

		[Address(RVA = "0x4B52F0", Offset = "0x4B44F0", Length = "0x12F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Material), Member = "set_mainTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x6002A3D")]
		internal void <ProcessPlayerAppearance>b__1(ImageCacheKey key, ImageCacheEntry entry) { }

		[Address(RVA = "0x4B5420", Offset = "0x4B4620", Length = "0xD8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Material), Member = "set_mainTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6002A3E")]
		internal void <ProcessPlayerAppearance>b__2(ImageCacheKey key, ImageCacheEntry entry) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20003EF")]
	private sealed class <ProcessPlayerAppearance>d__8 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001058")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001059")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400105A")]
		public Player player; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400105B")]
		private <>c__DisplayClass8_0 <>8__1; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400105C")]
		public AppearanceController <>4__this; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400105D")]
		private UnityWebRequest <uwr>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400105E")]
		private Enumerator <>7__wrap2; //Field offset: 0x40
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x400105F")]
		private GameObject <hat>5__4; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4001060")]
		private GltfImport <gltf>5__5; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4001061")]
		private Task<Boolean> <t>5__6; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4001062")]
		private Task<Boolean> <task>5__7; //Field offset: 0xA0

		[Token(Token = "0x17000CB5")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002A43")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000CB6")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002A45")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A3F")]
		public <ProcessPlayerAppearance>d__8(int <>1__state) { }

		[Address(RVA = "0x4B0730", Offset = "0x4AF930", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x6002A42")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x4AE870", Offset = "0x4ADA70", Length = "0x334")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[ContainsInvalidInstructions]
		[Token(Token = "0x6002A41")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A43")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A45")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4B0660", Offset = "0x4AF860", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6002A44")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x4B06A0", Offset = "0x4AF8A0", Length = "0x8F")]
		[CalledBy(Type = typeof(Vector3Value), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18049E7F0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DebuggerHidden]
		[Token(Token = "0x6002A40")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x400104C")]
	private static AppearanceController <Instance>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400104D")]
	private Queue<Player> playerQueue; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400104E")]
	private bool isProcessing; //Field offset: 0x28

	[Token(Token = "0x17000CB4")]
	public private static AppearanceController Instance
	{
		[Address(RVA = "0x49EEE0", Offset = "0x49E0E0", Length = "0x36")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x6002A34")]
		 get { } //Length: 54
		[Address(RVA = "0x49EF20", Offset = "0x49E120", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6002A35")]
		private set { } //Length: 81
	}

	[Address(RVA = "0x49EE60", Offset = "0x49E060", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002A3A")]
	public AppearanceController() { }

	[Address(RVA = "0x49EC10", Offset = "0x49DE10", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002A39")]
	public void AddPlayerToQueue(Player player) { }

	[Address(RVA = "0x49EC70", Offset = "0x49DE70", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002A36")]
	private void Awake() { }

	[Address(RVA = "0x49EEE0", Offset = "0x49E0E0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x6002A34")]
	public static AppearanceController get_Instance() { }

	[Address(RVA = "0x49ECD0", Offset = "0x49DED0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<ProcessPlayerAppearance>d__8))]
	[Token(Token = "0x6002A38")]
	private IEnumerator ProcessPlayerAppearance(Player player) { }

	[Address(RVA = "0x49EF20", Offset = "0x49E120", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x6002A35")]
	private static void set_Instance(AppearanceController value) { }

	[Address(RVA = "0x49ED60", Offset = "0x49DF60", Length = "0xFA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Dequeue", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002A37")]
	private void Update() { }

}

