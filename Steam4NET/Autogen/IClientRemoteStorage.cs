// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("CLIENTREMOTESTORAGE_INTERFACE_VERSION001")]
	public interface IClientRemoteStorage
	{
		[VTableSlot(0)]
		EResult FileWrite(UInt32 nAppId, ERemoteStorageFileRoot eRemoteStorageFileRoot, string pchFile, Byte[] pvData, Int32 cubData);
		[VTableSlot(1)]
		Int32 GetFileSize(UInt32 nAppId, ERemoteStorageFileRoot eRemoteStorageFileRoot, string pchFile);
		[VTableSlot(2)]
		Int32 FileRead(UInt32 nAppId, ERemoteStorageFileRoot eRemoteStorageFileRoot, string pchFile, Byte[] pvData, Int32 cubDataToRead);
		[VTableSlot(3)]
		bool FileForget(UInt32 nAppId, ERemoteStorageFileRoot eRemoteStorageFileRoot, string pchFile);
		[VTableSlot(4)]
		bool FileDelete(UInt32 nAppId, ERemoteStorageFileRoot eRemoteStorageFileRoot, string pchFile);
		[VTableSlot(5)]
		UInt64 FileShare(UInt32 nAppId, ERemoteStorageFileRoot eRemoteStorageFileRoot, string pchFile);
		[VTableSlot(6)]
		bool FileExists(UInt32 nAppId, ERemoteStorageFileRoot eRemoteStorageFileRoot, string pchFile);
		[VTableSlot(7)]
		bool FilePersisted(UInt32 nAppId, ERemoteStorageFileRoot eRemoteStorageFileRoot, string pchFile);
		[VTableSlot(8)]
		Int64 GetFileTimestamp(UInt32 nAppId, ERemoteStorageFileRoot eRemoteStorageFileRoot, string pchFile);
		[VTableSlot(9)]
		bool SetSyncPlatforms(UInt32 nAppId, ERemoteStorageFileRoot eRemoteStorageFileRoot, string pchFile, ERemoteStoragePlatform eRemoteStoragePlatform);
		[VTableSlot(10)]
		ERemoteStoragePlatform GetSyncPlatforms(UInt32 nAppId, ERemoteStorageFileRoot eRemoteStorageFileRoot, string pchFile);
		[VTableSlot(11)]
		UInt64 FileWriteStreamOpen(UInt32 nAppId, ERemoteStorageFileRoot eRemoteStorageFileRoot, string pchFile);
		[VTableSlot(12)]
		EResult FileWriteStreamClose(UInt64 hStream);
		[VTableSlot(13)]
		EResult FileWriteStreamCancel(UInt64 hStream);
		[VTableSlot(14)]
		EResult FileWriteStreamWriteChunk(UInt64 hStream, Byte[] pvData, Int32 cubData);
		[VTableSlot(15)]
		Int32 GetFileCount(UInt32 nAppId, bool bFromExternalAPI);
		[VTableSlot(16)]
		string GetFileNameAndSize(UInt32 nAppId, Int32 iFile, ref ERemoteStorageFileRoot peRemoteStorageFileRoot, ref Int32 pnFileSizeInBytes, bool bFromExternalAPI);
		[VTableSlot(17)]
		bool GetQuota(UInt32 nAppId, ref Int32 pnTotalBytes, ref Int32 pnAvailableBytes);
		[VTableSlot(18)]
		bool IsCloudEnabledForAccount();
		[VTableSlot(19)]
		bool IsCloudEnabledForApp(UInt32 nAppId);
		[VTableSlot(20)]
		void SetCloudEnabledForApp(UInt32 nAppId, bool bEnable);
		[VTableSlot(21)]
		UInt64 UGCDownload(UInt64 hContent, bool bUseNewCallback, UInt32 uUnk);
		[VTableSlot(22)]
		UInt64 UGCDownloadToLocation(UInt64 hContent, string cszLocation, UInt32 uUnk);
		[VTableSlot(23)]
		bool GetUGCDownloadProgress(UInt64 hContent, ref UInt32 puDownloadedBytes, ref UInt32 puTotalBytes);
		[VTableSlot(24)]
		bool GetUGCDetails(UInt64 hContent, ref UInt32 pnAppID, StringBuilder ppchName, ref Int32 pnFileSizeInBytes, ref CSteamID pSteamIDOwner);
		[VTableSlot(25)]
		Int32 UGCRead(UInt64 hContent, Byte[] pvData, Int32 cubDataToRead, UInt32 uOffset, EUGCReadAction eAction);
		[VTableSlot(26)]
		Int32 GetCachedUGCCount();
		[VTableSlot(27)]
		UInt64 GetCachedUGCHandle(Int32 iCachedContent);
		[VTableSlot(28)]
		UInt64 PublishFile(UInt32 nAppId, ERemoteStorageFileRoot eRemoteStorageFileRoot, string cszFileName, string cszPreviewFileName, UInt32 nConsumerAppId, string cszTitle, string cszDescription, ERemoteStoragePublishedFileVisibility eVisibility, ref SteamParamStringArray_t pTags, EWorkshopFileType eType);
		[VTableSlot(29)]
		UInt64 PublishVideo(UInt32 nAppId, EWorkshopVideoProvider eVideoProvider, string cszVideoAccountName, string cszVideoIdentifier, ERemoteStorageFileRoot eRemoteStorageFileRoot, string cszFileName, UInt32 nConsumerAppId, string cszTitle, string cszDescription, ERemoteStoragePublishedFileVisibility eVisibility, ref SteamParamStringArray_t pTags);
		[VTableSlot(30)]
		UInt64 PublishVideoFromURL(UInt32 nAppId, ERemoteStorageFileRoot eRemoteStorageFileRoot, string cszVideoURL, string cszFileName, UInt32 nConsumerAppId, string cszTitle, string cszDescription, ERemoteStoragePublishedFileVisibility eVisibility, ref SteamParamStringArray_t pTags);
		[VTableSlot(31)]
		UInt64 CreatePublishedFileUpdateRequest(UInt32 nAppId, UInt64 unPublishedFileId);
		[VTableSlot(32)]
		bool UpdatePublishedFileFile(UInt64 hUpdateRequest, string cszFile);
		[VTableSlot(33)]
		bool UpdatePublishedFilePreviewFile(UInt64 hUpdateRequest, string cszPreviewFile);
		[VTableSlot(34)]
		bool UpdatePublishedFileTitle(UInt64 hUpdateRequest, string cszTitle);
		[VTableSlot(35)]
		bool UpdatePublishedFileDescription(UInt64 hUpdateRequest, string cszDescription);
		[VTableSlot(36)]
		bool UpdatePublishedFileSetChangeDescription(UInt64 hUpdateRequest, string cszDescription);
		[VTableSlot(37)]
		bool UpdatePublishedFileVisibility(UInt64 hUpdateRequest, ERemoteStoragePublishedFileVisibility eVisibility);
		[VTableSlot(38)]
		bool UpdatePublishedFileTags(UInt64 hUpdateRequest, ref SteamParamStringArray_t pTags);
		[VTableSlot(39)]
		bool UpdatePublishedFileURL(UInt64 hUpdateRequest, string cszURL);
		[VTableSlot(40)]
		UInt64 CommitPublishedFileUpdate(UInt32 nAppId, ERemoteStorageFileRoot eRemoteStorageFileRoot, UInt64 hUpdateRequest);
		[VTableSlot(41)]
		UInt64 GetPublishedFileDetails(UInt64 unPublishedFileId, bool bUseNewCallback, UInt32 arg2);
		[VTableSlot(42)]
		UInt64 DeletePublishedFile(UInt64 unPublishedFileId);
		[VTableSlot(43)]
		UInt64 EnumerateUserPublishedFiles(UInt32 nAppId, UInt32 uStartIndex, ERemoteStoragePublishedFileSortOrder eOrder);
		[VTableSlot(44)]
		UInt64 SubscribePublishedFile(UInt32 nAppId, UInt64 unPublishedFileId);
		[VTableSlot(45)]
		UInt64 EnumerateUserSubscribedFiles(UInt32 nAppId, UInt32 uStartIndex, Byte uListType, EPublishedFileInfoMatchingFileType eMatchingFileType);
		[VTableSlot(46)]
		UInt64 UnsubscribePublishedFile(UInt32 nAppId, UInt64 unPublishedFileId);
		[VTableSlot(47)]
		UInt64 SetUserPublishedFileAction(UInt32 nAppId, UInt64 unPublishedFileId, EWorkshopFileAction eAction);
		[VTableSlot(48)]
		UInt64 EnumeratePublishedFilesByUserAction(UInt32 nAppId, EWorkshopFileAction eAction, UInt32 uStartIndex);
		[VTableSlot(49)]
		UInt64 EnumerateUserSubscribedFilesWithUpdates(UInt32 nAppId, UInt32 uStartIndex, UInt32 uStartTime);
		[VTableSlot(50)]
		UInt64 GetCREItemVoteSummary(UInt64 unPublishedFileId);
		[VTableSlot(51)]
		UInt64 UpdateUserPublishedItemVote(UInt64 unPublishedFileId, bool bVoteUp);
		[VTableSlot(52)]
		UInt64 GetUserPublishedItemVoteDetails(UInt64 unPublishedFileId);
		[VTableSlot(53)]
		UInt64 EnumerateUserSharedWorkshopFiles(UInt32 nAppId, CSteamID creatorSteamID, UInt32 uStartIndex, ref SteamParamStringArray_t pRequiredTags, ref SteamParamStringArray_t pExcludedTags);
		[VTableSlot(54)]
		UInt64 EnumeratePublishedWorkshopFiles(UInt32 nAppId, EWorkshopEnumerationType eType, EPublishedFileInfoMatchingFileType eFileType, UInt32 uStartIndex, UInt32 cDays, UInt32 cCount, ref SteamParamStringArray_t pTags, ref SteamParamStringArray_t pUserTags);
		[VTableSlot(55)]
		EFileRemoteStorageSyncState EGetFileSyncState(UInt32 nAppId, ERemoteStorageFileRoot eRemoteStorageFileRoot, string pchFile);
		[VTableSlot(56)]
		bool BIsFileSyncing(UInt32 nAppId, ERemoteStorageFileRoot eRemoteStorageFileRoot, string pchFile);
		[VTableSlot(57)]
		EResult FilePersist(UInt32 nAppId, ERemoteStorageFileRoot eRemoteStorageFileRoot, string pchFile);
		[VTableSlot(58)]
		bool FileFetch(UInt32 nAppId, ERemoteStorageFileRoot eRemoteStorageFileRoot, string pchFile);
		[VTableSlot(59)]
		bool ResolvePath(UInt32 nAppID, ERemoteStorageFileRoot eRemoteStorageFileRoot, string pchRelPath, StringBuilder pchDest, UInt32 cchDest);
		[VTableSlot(60)]
		EResult FileTouch(UInt32 nAppId, ERemoteStorageFileRoot eRemoteStorageFileRoot, string pchFile, bool arg3);
		[VTableSlot(61)]
		void SetCloudEnabledForAccount(bool bEnabled);
		[VTableSlot(62)]
		void LoadLocalFileInfoCache(UInt32 nAppId);
		[VTableSlot(63)]
		void EvaluateRemoteStorageSyncState(UInt32 nAppId, bool bUnk);
		[VTableSlot(64)]
		ERemoteStorageSyncState GetRemoteStorageSyncState(UInt32 nAppId);
		[VTableSlot(65)]
		bool HaveLatestFilesLocally(UInt32 nAppId);
		[VTableSlot(66)]
		bool GetConflictingFileTimestamps(UInt32 nAppId, ref UInt32 pnTimestampLocal, ref UInt32 pnTimestampRemote);
		[VTableSlot(67)]
		bool ResolveSyncConflict(UInt32 nAppId, bool bAcceptLocalFiles);
		[VTableSlot(68)]
		bool SynchronizeApp(UInt32 nAppId, bool bSyncClient, bool bSyncServer);
		[VTableSlot(69)]
		bool IsAppSyncInProgress(UInt32 nAppId);
		[VTableSlot(70)]
		void RunAutoCloudOnAppLaunch(UInt32 nAppId);
		[VTableSlot(71)]
		void RunAutoCloudOnAppExit(UInt32 nAppId);
		[VTableSlot(72)]
		bool ResetFileRequestState(UInt32 nAppId);
		[VTableSlot(73)]
		void ClearPublishFileUpdateRequests(UInt32 nAppId);
		[VTableSlot(74)]
		Int32 GetSubscribedFileDownloadCount();
		[VTableSlot(75)]
		bool BGetSubscribedFileDownloadInfo(Int32 iFile, ref UInt64 punPublishedFileId, ref UInt32 puBytesDownloaded, ref UInt32 puBytesExpected, ref UInt32 pnAppId);
		[VTableSlot(76)]
		bool BGetSubscribedFileDownloadInfo(UInt64 unPublishedFileId, ref UInt32 puBytesDownloaded, ref UInt32 puBytesExpected, ref UInt32 pnAppId);
		[VTableSlot(77)]
		void PauseSubscribedFileDownloadsForApp(UInt32 nAppId);
		[VTableSlot(78)]
		void ResumeSubscribedFileDownloadsForApp(UInt32 nAppId);
		[VTableSlot(79)]
		void PauseAllSubscribedFileDownloads();
		[VTableSlot(80)]
		void ResumeAllSubscribedFileDownloads();
		[VTableSlot(81)]
		void OnAppLifetime(UInt32 nAppId, bool bUnk);
	};
}
