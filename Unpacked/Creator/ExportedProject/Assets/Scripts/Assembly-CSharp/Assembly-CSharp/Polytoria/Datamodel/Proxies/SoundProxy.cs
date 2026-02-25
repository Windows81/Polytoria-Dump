namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003C0")]
public class SoundProxy : DynamicInstanceProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400100A")]
	private readonly Sound sound; //Field offset: 0x20

	[Token(Token = "0x17000C47")]
	public bool Autoplay
	{
		[Address(RVA = "0x4AC8E0", Offset = "0x4ABAE0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028D2")]
		 get { } //Length: 30
		[Address(RVA = "0x4ACA80", Offset = "0x4ABC80", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sound), Member = "set_Autoplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028D3")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C43")]
	public float Length
	{
		[Address(RVA = "0x4AC900", Offset = "0x4ABB00", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sound), Member = "get_Length", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028CB")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000C4D")]
	public LuaEvent Loaded
	{
		[Address(RVA = "0x4AC920", Offset = "0x4ABB20", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60028E0")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000C4C")]
	public bool Loading
	{
		[Address(RVA = "0x4AC940", Offset = "0x4ABB40", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028DC")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000C48")]
	public bool Loop
	{
		[Address(RVA = "0x4AC960", Offset = "0x4ABB60", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028D4")]
		 get { } //Length: 30
		[Address(RVA = "0x4ACAA0", Offset = "0x4ABCA0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sound), Member = "set_Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028D5")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C4B")]
	public float MaxDistance
	{
		[Address(RVA = "0x4AC980", Offset = "0x4ABB80", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028DA")]
		 get { } //Length: 31
		[Address(RVA = "0x4ACAC0", Offset = "0x4ABCC0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sound), Member = "set_MaxDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028DB")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C42")]
	public float Pitch
	{
		[Address(RVA = "0x4AC9A0", Offset = "0x4ABBA0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028C9")]
		 get { } //Length: 31
		[Address(RVA = "0x4ACAE0", Offset = "0x4ABCE0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sound), Member = "set_Pitch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028CA")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C40")]
	public bool Playing
	{
		[Address(RVA = "0x4AC9E0", Offset = "0x4ABBE0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028C6")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000C49")]
	public bool PlayInWorld
	{
		[Address(RVA = "0x4AC9C0", Offset = "0x4ABBC0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028D6")]
		 get { } //Length: 30
		[Address(RVA = "0x4ACB00", Offset = "0x4ABD00", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sound), Member = "set_PlayInWorld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028D7")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C45")]
	public Vector3 Rotation
	{
		[Address(RVA = "0x4ACA00", Offset = "0x4ABC00", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60028CE")]
		 get { } //Length: 59
		[Address(RVA = "0x4ACB20", Offset = "0x4ABD20", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sound), Member = "set_Rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028CF")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000C44")]
	public Vector3 Size
	{
		[Address(RVA = "0x4ACA00", Offset = "0x4ABC00", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60028CC")]
		 get { } //Length: 59
		[Address(RVA = "0x4ACB60", Offset = "0x4ABD60", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sound), Member = "set_Size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028CD")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000C41")]
	public int SoundID
	{
		[Address(RVA = "0x4A6B90", Offset = "0x4A5D90", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60028C7")]
		 get { } //Length: 29
		[Address(RVA = "0x4ACBA0", Offset = "0x4ABDA0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sound), Member = "set_SoundID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028C8")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C46")]
	public float Time
	{
		[Address(RVA = "0x4ACA40", Offset = "0x4ABC40", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sound), Member = "get_Time", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028D0")]
		 get { } //Length: 29
		[Address(RVA = "0x4ACBC0", Offset = "0x4ABDC0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sound), Member = "set_Time", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028D1")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C4A")]
	public float Volume
	{
		[Address(RVA = "0x4ACA60", Offset = "0x4ABC60", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sound), Member = "get_Volume", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028D8")]
		 get { } //Length: 29
		[Address(RVA = "0x4ACBE0", Offset = "0x4ABDE0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sound), Member = "set_Volume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028D9")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A11B0", Offset = "0x4A03B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60028C5")]
	public SoundProxy(Sound target) { }

	[Address(RVA = "0x4AC8E0", Offset = "0x4ABAE0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028D2")]
	public bool get_Autoplay() { }

	[Address(RVA = "0x4AC900", Offset = "0x4ABB00", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sound), Member = "get_Length", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028CB")]
	public float get_Length() { }

	[Address(RVA = "0x4AC920", Offset = "0x4ABB20", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60028E0")]
	public LuaEvent get_Loaded() { }

	[Address(RVA = "0x4AC940", Offset = "0x4ABB40", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028DC")]
	public bool get_Loading() { }

	[Address(RVA = "0x4AC960", Offset = "0x4ABB60", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028D4")]
	public bool get_Loop() { }

	[Address(RVA = "0x4AC980", Offset = "0x4ABB80", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028DA")]
	public float get_MaxDistance() { }

	[Address(RVA = "0x4AC9A0", Offset = "0x4ABBA0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028C9")]
	public float get_Pitch() { }

	[Address(RVA = "0x4AC9E0", Offset = "0x4ABBE0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028C6")]
	public bool get_Playing() { }

	[Address(RVA = "0x4AC9C0", Offset = "0x4ABBC0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028D6")]
	public bool get_PlayInWorld() { }

	[Address(RVA = "0x4ACA00", Offset = "0x4ABC00", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60028CE")]
	public Vector3 get_Rotation() { }

	[Address(RVA = "0x4ACA00", Offset = "0x4ABC00", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60028CC")]
	public Vector3 get_Size() { }

	[Address(RVA = "0x4A6B90", Offset = "0x4A5D90", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60028C7")]
	public int get_SoundID() { }

	[Address(RVA = "0x4ACA40", Offset = "0x4ABC40", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sound), Member = "get_Time", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028D0")]
	public float get_Time() { }

	[Address(RVA = "0x4ACA60", Offset = "0x4ABC60", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sound), Member = "get_Volume", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028D8")]
	public float get_Volume() { }

	[Address(RVA = "0x4AC8A0", Offset = "0x4ABAA0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sound), Member = "Play", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028DD")]
	public void Play() { }

	[Address(RVA = "0x4AC880", Offset = "0x4ABA80", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sound), Member = "PlayOneShot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028DE")]
	public void PlayOneShot(float volume = 1) { }

	[Address(RVA = "0x4ACA80", Offset = "0x4ABC80", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sound), Member = "set_Autoplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028D3")]
	public void set_Autoplay(bool value) { }

	[Address(RVA = "0x4ACAA0", Offset = "0x4ABCA0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sound), Member = "set_Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028D5")]
	public void set_Loop(bool value) { }

	[Address(RVA = "0x4ACAC0", Offset = "0x4ABCC0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sound), Member = "set_MaxDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028DB")]
	public void set_MaxDistance(float value) { }

	[Address(RVA = "0x4ACAE0", Offset = "0x4ABCE0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sound), Member = "set_Pitch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028CA")]
	public void set_Pitch(float value) { }

	[Address(RVA = "0x4ACB00", Offset = "0x4ABD00", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sound), Member = "set_PlayInWorld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028D7")]
	public void set_PlayInWorld(bool value) { }

	[Address(RVA = "0x4ACB20", Offset = "0x4ABD20", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sound), Member = "set_Rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028CF")]
	public void set_Rotation(Vector3 value) { }

	[Address(RVA = "0x4ACB60", Offset = "0x4ABD60", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sound), Member = "set_Size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028CD")]
	public void set_Size(Vector3 value) { }

	[Address(RVA = "0x4ACBA0", Offset = "0x4ABDA0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sound), Member = "set_SoundID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028C8")]
	public void set_SoundID(int value) { }

	[Address(RVA = "0x4ACBC0", Offset = "0x4ABDC0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sound), Member = "set_Time", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028D1")]
	public void set_Time(float value) { }

	[Address(RVA = "0x4ACBE0", Offset = "0x4ABDE0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sound), Member = "set_Volume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028D9")]
	public void set_Volume(float value) { }

	[Address(RVA = "0x4AC8C0", Offset = "0x4ABAC0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sound), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028DF")]
	public void Stop() { }

}

