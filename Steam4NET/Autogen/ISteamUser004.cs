// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("SteamUser004")]
	public interface ISteamUser004
	{
		[VTableSlot(0)]
		Int32 GetHSteamUser();
		[VTableSlot(1)]
		void LogOn(CSteamID steamID);
		[VTableSlot(2)]
		void LogOff();
		[VTableSlot(3)]
		bool BLoggedOn();
		[VTableSlot(4)]
		ELogonState GetLogonState();
		[VTableSlot(5)]
		bool BConnected();
		[VTableSlot(6)]
		CSteamID GetSteamID();
		[VTableSlot(7)]
		bool IsVACBanned(EVACBan eVACBan);
		[VTableSlot(8)]
		bool RequireShowVACBannedMessage(EVACBan eVACBan);
		[VTableSlot(9)]
		void AcknowledgeVACBanning(EVACBan eVACBan);
		[VTableSlot(10)]
		Int32 NClientGameIDAdd(Int32 nGameID);
		[VTableSlot(11)]
		void RemoveClientGame(Int32 nClientGameID);
		[VTableSlot(12)]
		void SetClientGameServer(Int32 nClientGameID, UInt32 unIPServer, UInt16 usPortServer);
		[VTableSlot(13)]
		void SetSteam2Ticket(Byte[] pubTicket, Int32 cubTicket);
		[VTableSlot(14)]
		void AddServerNetAddress(UInt32 unIP, UInt16 unPort);
		[VTableSlot(15)]
		bool SetEmail(string pchEmail);
		[VTableSlot(16)]
		Int32 GetSteamGameConnectToken(Byte[] pBlob, Int32 cbMaxBlob);
		[VTableSlot(17)]
		bool SetRegistryString(ERegistrySubTree eRegistrySubTree, string pchKey, string pchValue);
		[VTableSlot(18)]
		bool GetRegistryString(ERegistrySubTree eRegistrySubTree, string pchKey, StringBuilder pchValue, Int32 cbValue);
		[VTableSlot(19)]
		bool SetRegistryInt(ERegistrySubTree eRegistrySubTree, string pchKey, Int32 iValue);
		[VTableSlot(20)]
		bool GetRegistryInt(ERegistrySubTree eRegistrySubTree, string pchKey, ref Int32 piValue);
		[VTableSlot(21)]
		Int32 InitiateGameConnection(Byte[] pBlob, Int32 cbMaxBlob, CSteamID steamID, Int32 nGameAppID, UInt32 unIPServer, UInt16 usPortServer, bool bSecure);
		[VTableSlot(22)]
		void TerminateGameConnection(UInt32 unIPServer, UInt16 usPortServer);
		[VTableSlot(23)]
		void SetSelfAsPrimaryChatDestination();
		[VTableSlot(24)]
		bool IsPrimaryChatDestination();
		[VTableSlot(25)]
		void RequestLegacyCDKey(UInt32 iAppID);
	};
}
