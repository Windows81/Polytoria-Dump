using System.Runtime.InteropServices;
using Mirror.Discovery;
using Polytoria.Controllers;
using Polytoria.Datamodel;
using Polytoria.Networking;
using Polytoria.Types;
using TMPro;
using UnityEngine;

namespace Mirror
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	public static class GeneratedNetworkCode
	{
		public static TimeSnapshotMessage _Read_Mirror_002ETimeSnapshotMessage(NetworkReader reader)
		{
			return default(TimeSnapshotMessage);
		}

		public static void _Write_Mirror_002ETimeSnapshotMessage(NetworkWriter writer, TimeSnapshotMessage value)
		{
		}

		public static ReadyMessage _Read_Mirror_002EReadyMessage(NetworkReader reader)
		{
			return default(ReadyMessage);
		}

		public static void _Write_Mirror_002EReadyMessage(NetworkWriter writer, ReadyMessage value)
		{
		}

		public static NotReadyMessage _Read_Mirror_002ENotReadyMessage(NetworkReader reader)
		{
			return default(NotReadyMessage);
		}

		public static void _Write_Mirror_002ENotReadyMessage(NetworkWriter writer, NotReadyMessage value)
		{
		}

		public static AddPlayerMessage _Read_Mirror_002EAddPlayerMessage(NetworkReader reader)
		{
			return default(AddPlayerMessage);
		}

		public static void _Write_Mirror_002EAddPlayerMessage(NetworkWriter writer, AddPlayerMessage value)
		{
		}

		public static SceneMessage _Read_Mirror_002ESceneMessage(NetworkReader reader)
		{
			return default(SceneMessage);
		}

		public static SceneOperation _Read_Mirror_002ESceneOperation(NetworkReader reader)
		{
			return default(SceneOperation);
		}

		public static void _Write_Mirror_002ESceneMessage(NetworkWriter writer, SceneMessage value)
		{
		}

		public static void _Write_Mirror_002ESceneOperation(NetworkWriter writer, SceneOperation value)
		{
		}

		public static CommandMessage _Read_Mirror_002ECommandMessage(NetworkReader reader)
		{
			return default(CommandMessage);
		}

		public static void _Write_Mirror_002ECommandMessage(NetworkWriter writer, CommandMessage value)
		{
		}

		public static RpcMessage _Read_Mirror_002ERpcMessage(NetworkReader reader)
		{
			return default(RpcMessage);
		}

		public static void _Write_Mirror_002ERpcMessage(NetworkWriter writer, RpcMessage value)
		{
		}

		public static SpawnMessage _Read_Mirror_002ESpawnMessage(NetworkReader reader)
		{
			return default(SpawnMessage);
		}

		public static SpawnFlags _Read_Mirror_002ESpawnFlags(NetworkReader reader)
		{
			return default(SpawnFlags);
		}

		public static void _Write_Mirror_002ESpawnMessage(NetworkWriter writer, SpawnMessage value)
		{
		}

		public static void _Write_Mirror_002ESpawnFlags(NetworkWriter writer, SpawnFlags value)
		{
		}

		public static ChangeOwnerMessage _Read_Mirror_002EChangeOwnerMessage(NetworkReader reader)
		{
			return default(ChangeOwnerMessage);
		}

		public static void _Write_Mirror_002EChangeOwnerMessage(NetworkWriter writer, ChangeOwnerMessage value)
		{
		}

		public static ObjectSpawnStartedMessage _Read_Mirror_002EObjectSpawnStartedMessage(NetworkReader reader)
		{
			return default(ObjectSpawnStartedMessage);
		}

		public static void _Write_Mirror_002EObjectSpawnStartedMessage(NetworkWriter writer, ObjectSpawnStartedMessage value)
		{
		}

		public static ObjectSpawnFinishedMessage _Read_Mirror_002EObjectSpawnFinishedMessage(NetworkReader reader)
		{
			return default(ObjectSpawnFinishedMessage);
		}

		public static void _Write_Mirror_002EObjectSpawnFinishedMessage(NetworkWriter writer, ObjectSpawnFinishedMessage value)
		{
		}

		public static ObjectDestroyMessage _Read_Mirror_002EObjectDestroyMessage(NetworkReader reader)
		{
			return default(ObjectDestroyMessage);
		}

		public static void _Write_Mirror_002EObjectDestroyMessage(NetworkWriter writer, ObjectDestroyMessage value)
		{
		}

		public static ObjectHideMessage _Read_Mirror_002EObjectHideMessage(NetworkReader reader)
		{
			return default(ObjectHideMessage);
		}

		public static void _Write_Mirror_002EObjectHideMessage(NetworkWriter writer, ObjectHideMessage value)
		{
		}

		public static EntityStateMessage _Read_Mirror_002EEntityStateMessage(NetworkReader reader)
		{
			return default(EntityStateMessage);
		}

		public static void _Write_Mirror_002EEntityStateMessage(NetworkWriter writer, EntityStateMessage value)
		{
		}

		public static NetworkPingMessage _Read_Mirror_002ENetworkPingMessage(NetworkReader reader)
		{
			return default(NetworkPingMessage);
		}

		public static void _Write_Mirror_002ENetworkPingMessage(NetworkWriter writer, NetworkPingMessage value)
		{
		}

		public static NetworkPongMessage _Read_Mirror_002ENetworkPongMessage(NetworkReader reader)
		{
			return default(NetworkPongMessage);
		}

		public static void _Write_Mirror_002ENetworkPongMessage(NetworkWriter writer, NetworkPongMessage value)
		{
		}

		public static ServerRequest _Read_Mirror_002EDiscovery_002EServerRequest(NetworkReader reader)
		{
			return default(ServerRequest);
		}

		public static void _Write_Mirror_002EDiscovery_002EServerRequest(NetworkWriter writer, ServerRequest value)
		{
		}

		public static ServerResponse _Read_Mirror_002EDiscovery_002EServerResponse(NetworkReader reader)
		{
			return default(ServerResponse);
		}

		public static void _Write_Mirror_002EDiscovery_002EServerResponse(NetworkWriter writer, ServerResponse value)
		{
		}

		public static PTAuthenticator.AuthRequestMessage _Read_Polytoria_002ENetworking_002EPTAuthenticator_002FAuthRequestMessage(NetworkReader reader)
		{
			return default(PTAuthenticator.AuthRequestMessage);
		}

		public static void _Write_Polytoria_002ENetworking_002EPTAuthenticator_002FAuthRequestMessage(NetworkWriter writer, PTAuthenticator.AuthRequestMessage value)
		{
		}

		public static PTAuthenticator.AuthResponseMessage _Read_Polytoria_002ENetworking_002EPTAuthenticator_002FAuthResponseMessage(NetworkReader reader)
		{
			return default(PTAuthenticator.AuthResponseMessage);
		}

		public static void _Write_Polytoria_002ENetworking_002EPTAuthenticator_002FAuthResponseMessage(NetworkWriter writer, PTAuthenticator.AuthResponseMessage value)
		{
		}

		public static void _Write_Polytoria_002EDatamodel_002EPartShape(NetworkWriter writer, PartShape value)
		{
		}

		public static PartShape _Read_Polytoria_002EDatamodel_002EPartShape(NetworkReader reader)
		{
			return default(PartShape);
		}

		public static void _Write_Polytoria_002EDatamodel_002EPartMaterial(NetworkWriter writer, PartMaterial value)
		{
		}

		public static PartMaterial _Read_Polytoria_002EDatamodel_002EPartMaterial(NetworkReader reader)
		{
			return default(PartMaterial);
		}

		public static void _Write_UnityEngine_002EPhysicsMaterialCombine(NetworkWriter writer, PhysicsMaterialCombine value)
		{
		}

		public static PhysicsMaterialCombine _Read_UnityEngine_002EPhysicsMaterialCombine(NetworkReader reader)
		{
			return default(PhysicsMaterialCombine);
		}

		public static void _Write_Polytoria_002EControllers_002EImageType(NetworkWriter writer, ImageType value)
		{
		}

		public static ImageType _Read_Polytoria_002EControllers_002EImageType(NetworkReader reader)
		{
			return default(ImageType);
		}

		public static void _Write_Polytoria_002EDatamodel_002ESkyboxPreset(NetworkWriter writer, SkyboxPreset value)
		{
		}

		public static SkyboxPreset _Read_Polytoria_002EDatamodel_002ESkyboxPreset(NetworkReader reader)
		{
			return default(SkyboxPreset);
		}

		public static void _Write_Polytoria_002EDatamodel_002EImageSky_002FSkyboxSide(NetworkWriter writer, ImageSky.SkyboxSide value)
		{
		}

		public static ImageSky.SkyboxSide _Read_Polytoria_002EDatamodel_002EImageSky_002FSkyboxSide(NetworkReader reader)
		{
			return default(ImageSky.SkyboxSide);
		}

		public static void _Write_Polytoria_002EDatamodel_002EAmbientSource(NetworkWriter writer, AmbientSource value)
		{
		}

		public static AmbientSource _Read_Polytoria_002EDatamodel_002EAmbientSource(NetworkReader reader)
		{
			return default(AmbientSource);
		}

		public static void _Write_Polytoria_002EDatamodel_002ECollisionType(NetworkWriter writer, CollisionType value)
		{
		}

		public static CollisionType _Read_Polytoria_002EDatamodel_002ECollisionType(NetworkReader reader)
		{
			return default(CollisionType);
		}

		public static void _Write_Polytoria_002ETypes_002EColorRange(NetworkWriter writer, ColorRange value)
		{
		}

		public static void _Write_Polytoria_002EDatamodel_002EParticleColorMode(NetworkWriter writer, ParticleColorMode value)
		{
		}

		public static void _Write_Polytoria_002ETypes_002ENumberRange(NetworkWriter writer, NumberRange value)
		{
		}

		public static void _Write_Polytoria_002EDatamodel_002EParticleSimulationSpace(NetworkWriter writer, ParticleSimulationSpace value)
		{
		}

		public static void _Write_Polytoria_002EDatamodel_002EParticleShape(NetworkWriter writer, ParticleShape value)
		{
		}

		public static ColorRange _Read_Polytoria_002ETypes_002EColorRange(NetworkReader reader)
		{
			return default(ColorRange);
		}

		public static ParticleColorMode _Read_Polytoria_002EDatamodel_002EParticleColorMode(NetworkReader reader)
		{
			return default(ParticleColorMode);
		}

		public static NumberRange _Read_Polytoria_002ETypes_002ENumberRange(NetworkReader reader)
		{
			return default(NumberRange);
		}

		public static ParticleSimulationSpace _Read_Polytoria_002EDatamodel_002EParticleSimulationSpace(NetworkReader reader)
		{
			return default(ParticleSimulationSpace);
		}

		public static ParticleShape _Read_Polytoria_002EDatamodel_002EParticleShape(NetworkReader reader)
		{
			return default(ParticleShape);
		}

		public static void _Write_Polytoria_002EDatamodel_002EBodyPart(NetworkWriter writer, BodyPart value)
		{
		}

		public static BodyPart _Read_Polytoria_002EDatamodel_002EBodyPart(NetworkReader reader)
		{
			return default(BodyPart);
		}

		public static void _Write_TMPro_002EHorizontalAlignmentOptions(NetworkWriter writer, HorizontalAlignmentOptions value)
		{
		}

		public static HorizontalAlignmentOptions _Read_TMPro_002EHorizontalAlignmentOptions(NetworkReader reader)
		{
			return default(HorizontalAlignmentOptions);
		}

		public static void _Write_TMPro_002EVerticalAlignmentOptions(NetworkWriter writer, VerticalAlignmentOptions value)
		{
		}

		public static VerticalAlignmentOptions _Read_TMPro_002EVerticalAlignmentOptions(NetworkReader reader)
		{
			return default(VerticalAlignmentOptions);
		}

		public static void _Write_Polytoria_002EDatamodel_002ETextFontPreset(NetworkWriter writer, TextFontPreset value)
		{
		}

		public static TextFontPreset _Read_Polytoria_002EDatamodel_002ETextFontPreset(NetworkReader reader)
		{
			return default(TextFontPreset);
		}

		public static void _Write_Polytoria_002EDatamodel_002ETextJustify(NetworkWriter writer, TextJustify value)
		{
		}

		public static void _Write_Polytoria_002EDatamodel_002ETextVerticalAlign(NetworkWriter writer, TextVerticalAlign value)
		{
		}

		public static TextJustify _Read_Polytoria_002EDatamodel_002ETextJustify(NetworkReader reader)
		{
			return default(TextJustify);
		}

		public static TextVerticalAlign _Read_Polytoria_002EDatamodel_002ETextVerticalAlign(NetworkReader reader)
		{
			return default(TextVerticalAlign);
		}

		public static void _Write_UnityEngine_002ETextAnchor(NetworkWriter writer, TextAnchor value)
		{
		}

		public static TextAnchor _Read_UnityEngine_002ETextAnchor(NetworkReader reader)
		{
			return default(TextAnchor);
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		public static void InitReadWriters()
		{
		}
	}
}
