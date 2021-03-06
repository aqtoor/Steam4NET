// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("STEAM2BRIDGE_INTERFACE_VERSION001")]
	public interface ISteam2Bridge001
	{
		[VTableSlot(0)]
		void SetSteam2Ticket(Byte[] pubTicket, Int32 cubTicket);
		[VTableSlot(1)]
		bool SetAccountName(string pchAccountName);
		[VTableSlot(2)]
		bool SetPassword(string pchPassword);
		[VTableSlot(3)]
		bool SetAccountCreationTime(UInt32 rt);
		[VTableSlot(4)]
		bool CreateProcess(Byte[] lpVACBlob, UInt32 cbBlobSize, string lpApplicationName, StringBuilder lpCommandLine, UInt32 dwCreationFlags, Byte[] lpEnvironment, StringBuilder lpCurrentDirectory, UInt32 nGameID);
		[VTableSlot(5)]
		EUniverse GetConnectedUniverse();
		[VTableSlot(6)]
		string GetIPCountry();
		[VTableSlot(7)]
		UInt32 GetNumLicenses();
		[VTableSlot(8)]
		Int32 GetLicensePackageID(UInt32 nLicenseIndex);
		[VTableSlot(9)]
		UInt32 GetLicenseTimeCreated(UInt32 nLicenseIndex);
		[VTableSlot(10)]
		UInt32 GetLicenseTimeNextProcess(UInt32 nLicenseIndex);
		[VTableSlot(11)]
		Int32 GetLicenseMinuteLimit(UInt32 nLicenseIndex);
		[VTableSlot(12)]
		Int32 GetLicenseMinutesUsed(UInt32 nLicenseIndex);
		[VTableSlot(13)]
		EPaymentMethod GetLicensePaymentMethod(UInt32 nLicenseIndex);
		[VTableSlot(14)]
		ELicenseFlags GetLicenseFlags(UInt32 nLicenseIndex);
		[VTableSlot(15)]
		string GetLicensePurchaseCountryCode(UInt32 nLicenseIndex);
		[VTableSlot(16)]
		bool SetOfflineMode(bool bOffline);
	};
}
