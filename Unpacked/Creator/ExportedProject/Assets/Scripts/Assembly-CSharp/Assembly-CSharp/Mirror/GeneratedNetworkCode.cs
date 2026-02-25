namespace Mirror;

[Token(Token = "0x2000456")]
public static class GeneratedNetworkCode
{

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D42")]
	public static AddPlayerMessage _Read_Mirror.AddPlayerMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5AB0", Offset = "0x4F4CB0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D50")]
	public static ChangeOwnerMessage _Read_Mirror.ChangeOwnerMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5AF0", Offset = "0x4F4CF0", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(System.ArraySegment`1<System.Byte>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D48")]
	public static CommandMessage _Read_Mirror.CommandMessage(NetworkReader reader) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D60")]
	public static ServerRequest _Read_Mirror.Discovery.ServerRequest(NetworkReader reader) { }

	[Address(RVA = "0x4F5B70", Offset = "0x4F4D70", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Uri))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D62")]
	public static ServerResponse _Read_Mirror.Discovery.ServerResponse(NetworkReader reader) { }

	[Address(RVA = "0x4F5BD0", Offset = "0x4F4DD0", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(System.ArraySegment`1<System.Byte>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D5A")]
	public static EntityStateMessage _Read_Mirror.EntityStateMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5C30", Offset = "0x4F4E30", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(double))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D5C")]
	public static NetworkPingMessage _Read_Mirror.NetworkPingMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5C80", Offset = "0x4F4E80", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(double))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D5E")]
	public static NetworkPongMessage _Read_Mirror.NetworkPongMessage(NetworkReader reader) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D40")]
	public static NotReadyMessage _Read_Mirror.NotReadyMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5CE0", Offset = "0x4F4EE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D56")]
	public static ObjectDestroyMessage _Read_Mirror.ObjectDestroyMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5CE0", Offset = "0x4F4EE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D58")]
	public static ObjectHideMessage _Read_Mirror.ObjectHideMessage(NetworkReader reader) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D54")]
	public static ObjectSpawnFinishedMessage _Read_Mirror.ObjectSpawnFinishedMessage(NetworkReader reader) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D52")]
	public static ObjectSpawnStartedMessage _Read_Mirror.ObjectSpawnStartedMessage(NetworkReader reader) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D3E")]
	public static ReadyMessage _Read_Mirror.ReadyMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5AF0", Offset = "0x4F4CF0", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(System.ArraySegment`1<System.Byte>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D4A")]
	public static RpcMessage _Read_Mirror.RpcMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5CF0", Offset = "0x4F4EF0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D44")]
	public static SceneMessage _Read_Mirror.SceneMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5D50", Offset = "0x4F4F50", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D45")]
	public static SceneOperation _Read_Mirror.SceneOperation(NetworkReader reader) { }

	[Address(RVA = "0x4F5D50", Offset = "0x4F4F50", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D4D")]
	public static SpawnFlags _Read_Mirror.SpawnFlags(NetworkReader reader) { }

	[Address(RVA = "0x4F5D60", Offset = "0x4F4F60", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(System.ArraySegment`1<System.Byte>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D4C")]
	public static SpawnMessage _Read_Mirror.SpawnMessage(NetworkReader reader) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D3C")]
	public static TimeSnapshotMessage _Read_Mirror.TimeSnapshotMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5E40", Offset = "0x4F5040", Length = "0x7")]
	[CallerCount(Count = 54)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D6F")]
	public static ImageType _Read_Polytoria.Controllers.ImageType(NetworkReader reader) { }

	[Address(RVA = "0x4F5E40", Offset = "0x4F5040", Length = "0x7")]
	[CallerCount(Count = 54)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D75")]
	public static AmbientSource _Read_Polytoria.Datamodel.AmbientSource(NetworkReader reader) { }

	[Address(RVA = "0x4F5E40", Offset = "0x4F5040", Length = "0x7")]
	[CallerCount(Count = 54)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D83")]
	public static BodyPart _Read_Polytoria.Datamodel.BodyPart(NetworkReader reader) { }

	[Address(RVA = "0x4F5E40", Offset = "0x4F5040", Length = "0x7")]
	[CallerCount(Count = 54)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D77")]
	public static CollisionType _Read_Polytoria.Datamodel.CollisionType(NetworkReader reader) { }

	[Address(RVA = "0x4F5E40", Offset = "0x4F5040", Length = "0x7")]
	[CallerCount(Count = 54)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D73")]
	public static SkyboxSide _Read_Polytoria.Datamodel.ImageSky/SkyboxSide(NetworkReader reader) { }

	[Address(RVA = "0x4F5E40", Offset = "0x4F5040", Length = "0x7")]
	[CallerCount(Count = 54)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D7E")]
	public static ParticleColorMode _Read_Polytoria.Datamodel.ParticleColorMode(NetworkReader reader) { }

	[Address(RVA = "0x4F5E40", Offset = "0x4F5040", Length = "0x7")]
	[CallerCount(Count = 54)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D81")]
	public static ParticleShape _Read_Polytoria.Datamodel.ParticleShape(NetworkReader reader) { }

	[Address(RVA = "0x4F5E40", Offset = "0x4F5040", Length = "0x7")]
	[CallerCount(Count = 54)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D80")]
	public static ParticleSimulationSpace _Read_Polytoria.Datamodel.ParticleSimulationSpace(NetworkReader reader) { }

	[Address(RVA = "0x4F5E40", Offset = "0x4F5040", Length = "0x7")]
	[CallerCount(Count = 54)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D6B")]
	public static PartMaterial _Read_Polytoria.Datamodel.PartMaterial(NetworkReader reader) { }

	[Address(RVA = "0x4F5E40", Offset = "0x4F5040", Length = "0x7")]
	[CallerCount(Count = 54)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D69")]
	public static PartShape _Read_Polytoria.Datamodel.PartShape(NetworkReader reader) { }

	[Address(RVA = "0x4F5E40", Offset = "0x4F5040", Length = "0x7")]
	[CallerCount(Count = 54)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D71")]
	public static SkyboxPreset _Read_Polytoria.Datamodel.SkyboxPreset(NetworkReader reader) { }

	[Address(RVA = "0x4F5E40", Offset = "0x4F5040", Length = "0x7")]
	[CallerCount(Count = 54)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D89")]
	public static TextFontPreset _Read_Polytoria.Datamodel.TextFontPreset(NetworkReader reader) { }

	[Address(RVA = "0x4F5E40", Offset = "0x4F5040", Length = "0x7")]
	[CallerCount(Count = 54)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D8C")]
	public static TextJustify _Read_Polytoria.Datamodel.TextJustify(NetworkReader reader) { }

	[Address(RVA = "0x4F5E40", Offset = "0x4F5040", Length = "0x7")]
	[CallerCount(Count = 54)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D8D")]
	public static TextVerticalAlign _Read_Polytoria.Datamodel.TextVerticalAlign(NetworkReader reader) { }

	[Address(RVA = "0x4F5E50", Offset = "0x4F5050", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[Token(Token = "0x6002D64")]
	public static AuthRequestMessage _Read_Polytoria.Networking.PTAuthenticator/AuthRequestMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5EA0", Offset = "0x4F50A0", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002D66")]
	public static AuthResponseMessage _Read_Polytoria.Networking.PTAuthenticator/AuthResponseMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5F00", Offset = "0x4F5100", Length = "0x52")]
	[CalledBy(Type = typeof(Particles), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Color))]
	[Token(Token = "0x6002D7D")]
	public static ColorRange _Read_Polytoria.Types.ColorRange(NetworkReader reader) { }

	[Address(RVA = "0x4F5F60", Offset = "0x4F5160", Length = "0x35")]
	[CalledBy(Type = typeof(Particles), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(float))]
	[Token(Token = "0x6002D7F")]
	public static NumberRange _Read_Polytoria.Types.NumberRange(NetworkReader reader) { }

	[Address(RVA = "0x4F5E40", Offset = "0x4F5040", Length = "0x7")]
	[CallerCount(Count = 54)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D85")]
	public static HorizontalAlignmentOptions _Read_TMPro.HorizontalAlignmentOptions(NetworkReader reader) { }

	[Address(RVA = "0x4F5E40", Offset = "0x4F5040", Length = "0x7")]
	[CallerCount(Count = 54)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D87")]
	public static VerticalAlignmentOptions _Read_TMPro.VerticalAlignmentOptions(NetworkReader reader) { }

	[Address(RVA = "0x4F5E40", Offset = "0x4F5040", Length = "0x7")]
	[CallerCount(Count = 54)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D6D")]
	public static PhysicsMaterialCombine _Read_UnityEngine.PhysicsMaterialCombine(NetworkReader reader) { }

	[Address(RVA = "0x4F5E40", Offset = "0x4F5040", Length = "0x7")]
	[CallerCount(Count = 54)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D8F")]
	public static TextAnchor _Read_UnityEngine.TextAnchor(NetworkReader reader) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D43")]
	public static void _Write_Mirror.AddPlayerMessage(NetworkWriter writer, AddPlayerMessage value) { }

	[Address(RVA = "0x4F5FA0", Offset = "0x4F51A0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D51")]
	public static void _Write_Mirror.ChangeOwnerMessage(NetworkWriter writer, ChangeOwnerMessage value) { }

	[Address(RVA = "0x4F5FD0", Offset = "0x4F51D0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteUShort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D49")]
	public static void _Write_Mirror.CommandMessage(NetworkWriter writer, CommandMessage value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D61")]
	public static void _Write_Mirror.Discovery.ServerRequest(NetworkWriter writer, ServerRequest value) { }

	[Address(RVA = "0x4F6030", Offset = "0x4F5230", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Uri)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D63")]
	public static void _Write_Mirror.Discovery.ServerResponse(NetworkWriter writer, ServerResponse value) { }

	[Address(RVA = "0x4F6070", Offset = "0x4F5270", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D5B")]
	public static void _Write_Mirror.EntityStateMessage(NetworkWriter writer, EntityStateMessage value) { }

	[Address(RVA = "0x4F60B0", Offset = "0x4F52B0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(double)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D5D")]
	public static void _Write_Mirror.NetworkPingMessage(NetworkWriter writer, NetworkPingMessage value) { }

	[Address(RVA = "0x4F60F0", Offset = "0x4F52F0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(double)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D5F")]
	public static void _Write_Mirror.NetworkPongMessage(NetworkWriter writer, NetworkPongMessage value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D41")]
	public static void _Write_Mirror.NotReadyMessage(NetworkWriter writer, NotReadyMessage value) { }

	[Address(RVA = "0x4F6140", Offset = "0x4F5340", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D57")]
	public static void _Write_Mirror.ObjectDestroyMessage(NetworkWriter writer, ObjectDestroyMessage value) { }

	[Address(RVA = "0x4F6140", Offset = "0x4F5340", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D59")]
	public static void _Write_Mirror.ObjectHideMessage(NetworkWriter writer, ObjectHideMessage value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D55")]
	public static void _Write_Mirror.ObjectSpawnFinishedMessage(NetworkWriter writer, ObjectSpawnFinishedMessage value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D53")]
	public static void _Write_Mirror.ObjectSpawnStartedMessage(NetworkWriter writer, ObjectSpawnStartedMessage value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D3F")]
	public static void _Write_Mirror.ReadyMessage(NetworkWriter writer, ReadyMessage value) { }

	[Address(RVA = "0x4F5FD0", Offset = "0x4F51D0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteUShort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D4B")]
	public static void _Write_Mirror.RpcMessage(NetworkWriter writer, RpcMessage value) { }

	[Address(RVA = "0x4F6150", Offset = "0x4F5350", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D46")]
	public static void _Write_Mirror.SceneMessage(NetworkWriter writer, SceneMessage value) { }

	[Address(RVA = "0x4F61A0", Offset = "0x4F53A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D47")]
	public static void _Write_Mirror.SceneOperation(NetworkWriter writer, SceneOperation value) { }

	[Address(RVA = "0x4F61A0", Offset = "0x4F53A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D4F")]
	public static void _Write_Mirror.SpawnFlags(NetworkWriter writer, SpawnFlags value) { }

	[Address(RVA = "0x4F61B0", Offset = "0x4F53B0", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D4E")]
	public static void _Write_Mirror.SpawnMessage(NetworkWriter writer, SpawnMessage value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D3D")]
	public static void _Write_Mirror.TimeSnapshotMessage(NetworkWriter writer, TimeSnapshotMessage value) { }

	[Address(RVA = "0x4F6280", Offset = "0x4F5480", Length = "0x8")]
	[CallerCount(Count = 62)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D6E")]
	public static void _Write_Polytoria.Controllers.ImageType(NetworkWriter writer, ImageType value) { }

	[Address(RVA = "0x4F6280", Offset = "0x4F5480", Length = "0x8")]
	[CallerCount(Count = 62)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D74")]
	public static void _Write_Polytoria.Datamodel.AmbientSource(NetworkWriter writer, AmbientSource value) { }

	[Address(RVA = "0x4F6280", Offset = "0x4F5480", Length = "0x8")]
	[CallerCount(Count = 62)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D82")]
	public static void _Write_Polytoria.Datamodel.BodyPart(NetworkWriter writer, BodyPart value) { }

	[Address(RVA = "0x4F6280", Offset = "0x4F5480", Length = "0x8")]
	[CallerCount(Count = 62)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D76")]
	public static void _Write_Polytoria.Datamodel.CollisionType(NetworkWriter writer, CollisionType value) { }

	[Address(RVA = "0x4F6280", Offset = "0x4F5480", Length = "0x8")]
	[CallerCount(Count = 62)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D72")]
	public static void _Write_Polytoria.Datamodel.ImageSky/SkyboxSide(NetworkWriter writer, SkyboxSide value) { }

	[Address(RVA = "0x4F6280", Offset = "0x4F5480", Length = "0x8")]
	[CallerCount(Count = 62)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D79")]
	public static void _Write_Polytoria.Datamodel.ParticleColorMode(NetworkWriter writer, ParticleColorMode value) { }

	[Address(RVA = "0x4F6280", Offset = "0x4F5480", Length = "0x8")]
	[CallerCount(Count = 62)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D7C")]
	public static void _Write_Polytoria.Datamodel.ParticleShape(NetworkWriter writer, ParticleShape value) { }

	[Address(RVA = "0x4F6280", Offset = "0x4F5480", Length = "0x8")]
	[CallerCount(Count = 62)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D7B")]
	public static void _Write_Polytoria.Datamodel.ParticleSimulationSpace(NetworkWriter writer, ParticleSimulationSpace value) { }

	[Address(RVA = "0x4F6280", Offset = "0x4F5480", Length = "0x8")]
	[CallerCount(Count = 62)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D6A")]
	public static void _Write_Polytoria.Datamodel.PartMaterial(NetworkWriter writer, PartMaterial value) { }

	[Address(RVA = "0x4F6280", Offset = "0x4F5480", Length = "0x8")]
	[CallerCount(Count = 62)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D68")]
	public static void _Write_Polytoria.Datamodel.PartShape(NetworkWriter writer, PartShape value) { }

	[Address(RVA = "0x4F6280", Offset = "0x4F5480", Length = "0x8")]
	[CallerCount(Count = 62)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D70")]
	public static void _Write_Polytoria.Datamodel.SkyboxPreset(NetworkWriter writer, SkyboxPreset value) { }

	[Address(RVA = "0x4F6280", Offset = "0x4F5480", Length = "0x8")]
	[CallerCount(Count = 62)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D88")]
	public static void _Write_Polytoria.Datamodel.TextFontPreset(NetworkWriter writer, TextFontPreset value) { }

	[Address(RVA = "0x4F6280", Offset = "0x4F5480", Length = "0x8")]
	[CallerCount(Count = 62)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D8A")]
	public static void _Write_Polytoria.Datamodel.TextJustify(NetworkWriter writer, TextJustify value) { }

	[Address(RVA = "0x4F6280", Offset = "0x4F5480", Length = "0x8")]
	[CallerCount(Count = 62)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D8B")]
	public static void _Write_Polytoria.Datamodel.TextVerticalAlign(NetworkWriter writer, TextVerticalAlign value) { }

	[Address(RVA = "0x4F6290", Offset = "0x4F5490", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002D65")]
	public static void _Write_Polytoria.Networking.PTAuthenticator/AuthRequestMessage(NetworkWriter writer, AuthRequestMessage value) { }

	[Address(RVA = "0x4F62D0", Offset = "0x4F54D0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002D67")]
	public static void _Write_Polytoria.Networking.PTAuthenticator/AuthResponseMessage(NetworkWriter writer, AuthResponseMessage value) { }

	[Address(RVA = "0x4F6320", Offset = "0x4F5520", Length = "0x49")]
	[CalledBy(Type = typeof(Particles), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Color)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002D78")]
	public static void _Write_Polytoria.Types.ColorRange(NetworkWriter writer, ColorRange value) { }

	[Address(RVA = "0x4F6370", Offset = "0x4F5570", Length = "0x32")]
	[CalledBy(Type = typeof(Particles), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002D7A")]
	public static void _Write_Polytoria.Types.NumberRange(NetworkWriter writer, NumberRange value) { }

	[Address(RVA = "0x4F6280", Offset = "0x4F5480", Length = "0x8")]
	[CallerCount(Count = 62)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D84")]
	public static void _Write_TMPro.HorizontalAlignmentOptions(NetworkWriter writer, HorizontalAlignmentOptions value) { }

	[Address(RVA = "0x4F6280", Offset = "0x4F5480", Length = "0x8")]
	[CallerCount(Count = 62)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D86")]
	public static void _Write_TMPro.VerticalAlignmentOptions(NetworkWriter writer, VerticalAlignmentOptions value) { }

	[Address(RVA = "0x4F6280", Offset = "0x4F5480", Length = "0x8")]
	[CallerCount(Count = 62)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D6C")]
	public static void _Write_UnityEngine.PhysicsMaterialCombine(NetworkWriter writer, PhysicsMaterialCombine value) { }

	[Address(RVA = "0x4F6280", Offset = "0x4F5480", Length = "0x8")]
	[CallerCount(Count = 62)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D8E")]
	public static void _Write_UnityEngine.TextAnchor(NetworkWriter writer, TextAnchor value) { }

	[Address(RVA = "0x4EF5D0", Offset = "0x4EE7D0", Length = "0x64DD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Action`2<System.Object, UnityEngine.Matrix4x4>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Action`2<System.Object, Polytoria.Types.ColorRange>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Action`2<System.Object, Mirror.SpawnMessage>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Action`2<System.Object, System.Nullable`1<UnityEngine.Matrix4x4>>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Func`2<System.Object, Mirror.SpawnMessage>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Action`2<System.Object, System.Nullable`1<UnityEngine.Ray>>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Nullable`1<UnityEngine.Matrix4x4>>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Nullable`1<UnityEngine.Ray>>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Func`2<System.Object, UnityEngine.Matrix4x4>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 91)]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	[Token(Token = "0x6002D90")]
	public static void InitReadWriters() { }

}

