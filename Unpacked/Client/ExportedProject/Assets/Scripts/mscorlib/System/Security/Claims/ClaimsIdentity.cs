namespace System.Security.Claims;

[ComVisible(True)]
[Token(Token = "0x2000330")]
public class ClaimsIdentity : IIdentity
{
	[CompilerGenerated]
	[Token(Token = "0x2000331")]
	private sealed class <get_Claims>d__51 : IEnumerable<Claim>, IEnumerable, IEnumerator<Claim>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000DB3")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000DB4")]
		private Claim <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000DB5")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000DB6")]
		public ClaimsIdentity <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000DB7")]
		private int <i>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000DB8")]
		private IEnumerator<Claim> <>7__wrap2; //Field offset: 0x38

		[Token(Token = "0x170002B4")]
		private override Claim System.Collections.Generic.IEnumerator<System.Security.Claims.Claim>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60019AF")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170002B5")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60019B1")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x313540", Offset = "0x312740", Length = "0x2E")]
		[CallerCount(Count = 17)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60019AB")]
		public <get_Claims>d__51(int <>1__state) { }

		[Address(RVA = "0x1378000", Offset = "0x1377200", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x60019AE")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x1377B40", Offset = "0x1376D40", Length = "0x34B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Collection`1), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181357540")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x60019AD")]
		private override bool MoveNext() { }

		[Address(RVA = "0x1377E90", Offset = "0x1377090", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60019B2")]
		private override IEnumerator<Claim> System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60019AF")]
		private override Claim System.Collections.Generic.IEnumerator<System.Security.Claims.Claim>.get_Current() { }

		[Address(RVA = "0x1377E90", Offset = "0x1377090", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60019B3")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60019B1")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1377F30", Offset = "0x1377130", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x60019B0")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x1377F70", Offset = "0x1377170", Length = "0x8C")]
		[CalledBy(Type = typeof(X509Helper), Member = "get_CertificateProvider", ReturnType = typeof(ISystemCertificateProvider))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813574E0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DebuggerHidden]
		[Token(Token = "0x60019AC")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000DA6")]
	private Byte[] m_userSerializationData; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000DA7")]
	private List<Claim> m_instanceClaims; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000DA8")]
	private Collection<IEnumerable`1<Claim>> m_externalClaims; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000DA9")]
	private string m_nameType; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000DAA")]
	private string m_roleType; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x4000DAB")]
	private string m_version; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x4000DAC")]
	private ClaimsIdentity m_actor; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x4000DAD")]
	private string m_authenticationType; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x4000DAE")]
	private object m_bootstrapContext; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x4000DAF")]
	private string m_label; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x4000DB0")]
	private string m_serializedNameType; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x4000DB1")]
	private string m_serializedRoleType; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x4000DB2")]
	private string m_serializedClaims; //Field offset: 0x70

	[Token(Token = "0x170002B1")]
	public ClaimsIdentity Actor
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600199B")]
		 get { } //Length: 5
		[Address(RVA = "0x135ED10", Offset = "0x135DF10", Length = "0xB4")]
		[CalledBy(Type = typeof(ClaimsIdentity), Member = "Clone", ReturnType = typeof(ClaimsIdentity))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600199C")]
		 set { } //Length: 180
	}

	[Token(Token = "0x170002B0")]
	public override string AuthenticationType
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x600199A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002B2")]
	public override IEnumerable<Claim> Claims
	{
		[Address(RVA = "0x135EC60", Offset = "0x135DE60", Length = "0x71")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 2)]
		[IteratorStateMachine(typeof(<get_Claims>d__51))]
		[Token(Token = "0x600199D")]
		 get { } //Length: 113
	}

	[Token(Token = "0x170002B3")]
	public override string Name
	{
		[Address(RVA = "0x135ECE0", Offset = "0x135DEE0", Length = "0x2E")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600199E")]
		 get { } //Length: 46
	}

	[Address(RVA = "0x135E3F0", Offset = "0x135D5F0", Length = "0x2C")]
	[CalledBy(Type = typeof(WindowsIdentity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(WindowsAccountType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WindowsIdentity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WindowsIdentity), Member = "GetCurrent", ReturnType = typeof(WindowsIdentity))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ClaimsIdentity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IIdentity), typeof(System.Collections.Generic.IEnumerable`1<System.Security.Claims.Claim>), typeof(string), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001995")]
	public ClaimsIdentity() { }

	[Address(RVA = "0x135E3C0", Offset = "0x135D5C0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClaimsIdentity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IIdentity), typeof(System.Collections.Generic.IEnumerable`1<System.Security.Claims.Claim>), typeof(string), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001996")]
	public ClaimsIdentity(IEnumerable<Claim> claims) { }

	[Address(RVA = "0x135EC30", Offset = "0x135DE30", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClaimsIdentity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IIdentity), typeof(System.Collections.Generic.IEnumerable`1<System.Security.Claims.Claim>), typeof(string), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001997")]
	public ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType) { }

	[Address(RVA = "0x135E5E0", Offset = "0x135D7E0", Length = "0x64F")]
	[CalledBy(Type = typeof(ClaimsIdentity), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClaimsIdentity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Security.Claims.Claim>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClaimsIdentity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IIdentity), typeof(System.Collections.Generic.IEnumerable`1<System.Security.Claims.Claim>), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClaimsIdentity), Member = "Clone", ReturnType = typeof(ClaimsIdentity))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(Claim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(ClaimsIdentity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(ClaimsIdentity), Member = "SafeAddClaims", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Security.Claims.Claim>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Collection`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001998")]
	internal ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType, bool checkAuthType) { }

	[Address(RVA = "0x135E420", Offset = "0x135D620", Length = "0x1BF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Collection`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ClaimsIdentity), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001999")]
	protected ClaimsIdentity(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x135CB10", Offset = "0x135BD10", Length = "0x1C6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ClaimsIdentity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IIdentity), typeof(System.Collections.Generic.IEnumerable`1<System.Security.Claims.Claim>), typeof(string), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ClaimsIdentity), Member = "set_Actor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClaimsIdentity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600199F")]
	public override ClaimsIdentity Clone() { }

	[Address(RVA = "0x135CFA0", Offset = "0x135C1A0", Length = "0x691")]
	[CalledBy(Type = typeof(ClaimsIdentity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ClaimsIdentity), Member = "DeserializeClaims", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BinaryFormatter), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(HeaderHandler), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(SerializationInfoEnumerator))]
	[Calls(Type = typeof(BinaryFormatter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ISurrogateSelector), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryFormatter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[Token(Token = "0x60019AA")]
	private void Deserialize(SerializationInfo info, StreamingContext context, bool useContext) { }

	[Address(RVA = "0x135CCE0", Offset = "0x135BEE0", Length = "0x2B3")]
	[CalledBy(Type = typeof(ClaimsIdentity), Member = "OnDeserializedMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClaimsIdentity), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BinaryFormatter), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(HeaderHandler), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(BinaryFormatter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60019A7")]
	private void DeserializeClaims(string serializedClaims) { }

	[Address(RVA = "0x135D640", Offset = "0x135C840", Length = "0x1E8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019A2")]
	public override Claim FindFirst(string type) { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600199B")]
	public ClaimsIdentity get_Actor() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x600199A")]
	public override string get_AuthenticationType() { }

	[Address(RVA = "0x135EC60", Offset = "0x135DE60", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[IteratorStateMachine(typeof(<get_Claims>d__51))]
	[Token(Token = "0x600199D")]
	public override IEnumerable<Claim> get_Claims() { }

	[Address(RVA = "0x135ECE0", Offset = "0x135DEE0", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600199E")]
	public override string get_Name() { }

	[Address(RVA = "0x135D830", Offset = "0x135CA30", Length = "0x482")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryFormatter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(object), typeof(Header[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ClaimsIdentity), Member = "SerializeClaims", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryFormatter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60019A6")]
	protected override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x135DCC0", Offset = "0x135CEC0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019A9")]
	private bool IsCircular(ClaimsIdentity subject) { }

	[Address(RVA = "0x135DD10", Offset = "0x135CF10", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClaimsIdentity), Member = "DeserializeClaims", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[OnDeserialized]
	[Token(Token = "0x60019A4")]
	private void OnDeserializedMethod(StreamingContext context) { }

	[Address(RVA = "0x135DDF0", Offset = "0x135CFF0", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Collection`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[OnDeserializing]
	[Token(Token = "0x60019A5")]
	private void OnDeserializingMethod(StreamingContext context) { }

	[Address(RVA = "0x135DED0", Offset = "0x135D0D0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(ClaimsIdentity), Member = "SerializeClaims", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[OnSerializing]
	[Token(Token = "0x60019A3")]
	private void OnSerializingMethod(StreamingContext context) { }

	[Address(RVA = "0x135DF50", Offset = "0x135D150", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019A1")]
	private void SafeAddClaim(Claim claim) { }

	[Address(RVA = "0x135DFF0", Offset = "0x135D1F0", Length = "0x21B")]
	[CalledBy(Type = typeof(ClaimsIdentity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IIdentity), typeof(System.Collections.Generic.IEnumerable`1<System.Security.Claims.Claim>), typeof(string), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60019A0")]
	private void SafeAddClaims(IEnumerable<Claim> claims) { }

	[Address(RVA = "0x135E210", Offset = "0x135D410", Length = "0x1A6")]
	[CalledBy(Type = typeof(ClaimsIdentity), Member = "OnSerializingMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClaimsIdentity), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryFormatter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryFormatter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(object), typeof(Header[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60019A8")]
	private string SerializeClaims() { }

	[Address(RVA = "0x135ED10", Offset = "0x135DF10", Length = "0xB4")]
	[CalledBy(Type = typeof(ClaimsIdentity), Member = "Clone", ReturnType = typeof(ClaimsIdentity))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600199C")]
	public void set_Actor(ClaimsIdentity value) { }

}

