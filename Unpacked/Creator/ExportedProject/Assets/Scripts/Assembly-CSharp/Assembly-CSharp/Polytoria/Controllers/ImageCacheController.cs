namespace Polytoria.Controllers;

[Token(Token = "0x2000401")]
public class ImageCacheController : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000402")]
	private sealed class <>c
	{
		[Token(Token = "0x40010CD")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40010CE")]
		public static Func<Color32, Boolean> <>9__12_0; //Field offset: 0x8

		[Address(RVA = "0x4CF4E0", Offset = "0x4CE6E0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002B0A")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B0B")]
		public <>c() { }

		[Address(RVA = "0x4CF270", Offset = "0x4CE470", Length = "0x15")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002B0C")]
		internal bool <LoadImage>b__12_0(Color32 c) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000403")]
	private sealed class <LoadImage>d__12 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40010CF")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40010D0")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40010D1")]
		public ImageCacheKey key; //Field offset: 0x20
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40010D2")]
		public int tries; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40010D3")]
		public ImageCacheController <>4__this; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40010D4")]
		private string <url>5__2; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40010D5")]
		private UnityWebRequest <uwr>5__3; //Field offset: 0x50

		[Token(Token = "0x17000CDB")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002B12")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000CDC")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002B14")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B0D")]
		public <LoadImage>d__12(int <>1__state) { }

		[Address(RVA = "0x4CB9D0", Offset = "0x4CABD0", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x6002B10")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x4CBA20", Offset = "0x4CAC20", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x6002B11")]
		private void <>m__Finally2() { }

		[Address(RVA = "0x4CA9F0", Offset = "0x4C9BF0", Length = "0xE24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JSON), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JSONNode))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Texture2D), Member = "GetPixels32", ReturnType = typeof(Color32[]))]
		[Calls(Type = typeof(DownloadHandlerTexture), Member = "GetContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest)}, ReturnType = typeof(Texture2D))]
		[Calls(Type = typeof(UnityWebRequestTexture), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(ImageCacheController), Member = "LoadImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageCacheKey), typeof(int)}, ReturnType = typeof(IEnumerator))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Polytoria.Controllers.ImageCacheKey, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageCacheKey)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(WaitForSeconds), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
		[Calls(Type = typeof(LaunchController), Member = "GetActiveToken", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804B6480")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		[Token(Token = "0x6002B0F")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B12")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B14")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4CB840", Offset = "0x4CAA40", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6002B13")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x4CB880", Offset = "0x4CAA80", Length = "0x118")]
		[CalledBy(Type = typeof(Vector3ValueProxy), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804B6700")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804B64A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerHidden]
		[Token(Token = "0x6002B0E")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000404")]
	private sealed class <WaitForImage>d__10 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40010D6")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40010D7")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40010D8")]
		public Action<ImageCacheKey, ImageCacheEntry> callback; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40010D9")]
		public ImageCacheKey key; //Field offset: 0x28
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40010DA")]
		public ImageCacheController <>4__this; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40010DB")]
		private float <time>5__2; //Field offset: 0x48

		[Token(Token = "0x17000CDD")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002B18")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000CDE")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002B1A")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B15")]
		public <WaitForImage>d__10(int <>1__state) { }

		[Address(RVA = "0x4CF5C0", Offset = "0x4CE7C0", Length = "0x1F4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Polytoria.Controllers.ImageCacheKey, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageCacheKey), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002B17")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B18")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B1A")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4CF7C0", Offset = "0x4CE9C0", Length = "0x583")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = "Polytoria.Controllers.CreatorController+<CheckToken>d__50", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "Polytoria.Controllers.CreatorController+<DoPublish>d__74", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "Polytoria.Controllers.UIController+<LoadThumbnail>d__134", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "Polytoria.Controllers.ToolboxController+<DoReloadToolbox>d__22", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "Polytoria.Controllers.CreatorController+<LoadStarterPlaces>d__68", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "Polytoria.Controllers.CreatorController+<DoPublishModel>d__62", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "Polytoria.Controllers.ToolboxController+<LoadThumbnail>d__23", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "Polytoria.Controllers.UIController+<LoadLeaderboardThumbnail>d__121", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[Token(Token = "0x6002B19")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B16")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x40010C8")]
	private static ImageCacheController <Instance>k__BackingField; //Field offset: 0x0
	[Token(Token = "0x40010C9")]
	private static Dictionary<ImageCacheKey, ImageCacheEntry> cache; //Field offset: 0x8
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40010CA")]
	private Queue<ImageCacheKey> loadQueue; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40010CB")]
	private Texture2D fallback; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40010CC")]
	private bool loading; //Field offset: 0x30

	[Token(Token = "0x17000CDA")]
	public private static ImageCacheController Instance
	{
		[Address(RVA = "0x4C2AA0", Offset = "0x4C1CA0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6002B01")]
		 get { } //Length: 78
		[Address(RVA = "0x4C2AF0", Offset = "0x4C1CF0", Length = "0x69")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6002B02")]
		private set { } //Length: 105
	}

	[Address(RVA = "0x4C2990", Offset = "0x4C1B90", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Polytoria.Controllers.ImageCacheKey, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002B09")]
	private static ImageCacheController() { }

	[Address(RVA = "0x4C2A20", Offset = "0x4C1C20", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002B08")]
	public ImageCacheController() { }

	[Address(RVA = "0x4C2300", Offset = "0x4C1500", Length = "0x192")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Token(Token = "0x6002B03")]
	private void Awake() { }

	[Address(RVA = "0x4C2AA0", Offset = "0x4C1CA0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6002B01")]
	public static ImageCacheController get_Instance() { }

	[Address(RVA = "0x4C24A0", Offset = "0x4C16A0", Length = "0x284")]
	[CalledBy(Type = typeof(UIImage), Member = "GetImage", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Decal), Member = "GetImage", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NPC), Member = "set_ShirtID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NPC), Member = "set_PantsID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NPC), Member = "set_FaceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Particles), Member = "GetImage", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "set_ShirtID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "set_PantsID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "set_FaceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Polytoria.Controllers.ImageCacheKey, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageCacheKey), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Polytoria.Controllers.ImageCacheKey, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageCacheKey), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<Polytoria.Controllers.ImageCacheKey>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageCacheKey)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ImageCacheController), Member = "WaitForImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageCacheKey), typeof(System.Action`2<Polytoria.Controllers.ImageCacheKey, Polytoria.Controllers.ImageCacheEntry>)}, ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002B04")]
	public void GetImage(ImageCacheKey key, Action<ImageCacheKey, ImageCacheEntry> callback) { }

	[Address(RVA = "0x4C2730", Offset = "0x4C1930", Length = "0xA0")]
	[CalledBy(Type = typeof(<LoadImage>d__12), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<LoadImage>d__12))]
	[Token(Token = "0x6002B07")]
	private IEnumerator LoadImage(ImageCacheKey key, int tries = 0) { }

	[Address(RVA = "0x4C2AF0", Offset = "0x4C1CF0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x6002B02")]
	private static void set_Instance(ImageCacheController value) { }

	[Address(RVA = "0x4C27D0", Offset = "0x4C19D0", Length = "0x108")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<Polytoria.Controllers.ImageCacheKey>), Member = "Dequeue", ReturnType = typeof(ImageCacheKey))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002B06")]
	private void Update() { }

	[Address(RVA = "0x4C28E0", Offset = "0x4C1AE0", Length = "0xAD")]
	[CalledBy(Type = typeof(ImageCacheController), Member = "GetImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageCacheKey), typeof(System.Action`2<Polytoria.Controllers.ImageCacheKey, Polytoria.Controllers.ImageCacheEntry>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<WaitForImage>d__10))]
	[Token(Token = "0x6002B05")]
	private IEnumerator WaitForImage(ImageCacheKey key, Action<ImageCacheKey, ImageCacheEntry> callback) { }

}

