Corona injector CLI
Copyright (C) 2011-2012 by iPhone Dev Team
http://blog.iphone-dev.org 
With exploit work by: @pod2g, @planetbeing, @saurik, @pimskeks, @p0sixninja, @MuscleNerd, and @xvolks

DO NOT SELL - STRICTLY NO COMMERCIAL USE

-------------------------------------------------------
USAGE
-------------------------------------------------------
  Configuration profiles:
    -l             List current profiles
    -i <file>      Install profile
    -r [<pattern>] Remove all profiles, or profiles matching pattern

  AFC transfers:
    -a <number>    Alternative afc service to use (2 is available after jailbreak)
    -u <file> ...  Upload file(s) via afc (add final "dir=dirname" to specify which afc directory)
    -d [<dir>]     Show list of files in afc directory
    -X <path>      Delete afc directory or file

  ROP assistance:
    -s             Compute slide
    -e             Erase existing crash logs
    -g             Get diagnostics

  Backups and restores:
    -B             Create backup
    -R             Restore from backup
    -L <mbdb_file> List contents of an MBDB file
    -M <file>      Modify the ipsec.plist on device
    -p <file>      Modify the preferences.plist (requires -f too)
    -f <file>      File to use with -p
    -H             Hide media files
    -U             Unhide media files

  Chained operations:
    -j <dir>       Jailbreak device using given payloads directory (ADVANCED use only!)

  Other:
    -w             Watch syslog
    -v <level>     Debug verbosity level
    -h             This help message

-------------------------------------------------------
EXAMPLES
-------------------------------------------------------
% cinject -s
   DEVICE: iPad2,1
   OS:     9A405
   PIDLEN: 3
   SLIDE:  0x4a1000

% cinject -d
Books/
DCIM/
Downloads/
PhotoData/
Photos/
Purchases/
Recordings/
com.apple.itunes.lock_sync
corona/
iTunes_Control/

% cinject -v 2 -H
Hiding media...
Books -> HackStore/Books
DCIM -> HackStore/DCIM
Downloads -> HackStore/Downloads
PhotoData -> HackStore/PhotoData
Photos -> HackStore/Photos
Purchases -> HackStore/Purchases
Recordings -> HackStore/Recordings
com.apple.itunes.lock_sync -> HackStore/com.apple.itunes.lock_sync

% cinject -d
HackStore/
corona/
iTunes_Control/

% cinject -v 2 -U
HackStore/Books -> ./Books
HackStore/DCIM -> ./DCIM
HackStore/Downloads -> ./Downloads
HackStore/PhotoData -> ./PhotoData
HackStore/Photos -> ./Photos
HackStore/Purchases -> ./Purchases
HackStore/Recordings -> ./Recordings
HackStore/com.apple.itunes.lock_sync -> ./com.apple.itunes.lock_sync

% cinject -j payloads

Please first run: cinject -i payloads/jailbreak.mobileconfig
Do so with device unlocked and approve the install request.

Error

% cinject -i payloads/jailbreak.mobileconfig 

% cinject -j payloads
Finding slide...
Generating ROP...
ROP was generated
Uploaded corona/payload
Uploaded corona/payload-vars
Uploaded corona/racoon-exploit.conf
Uploaded corona/vnimage.clean
Uploaded corona/vnimage.overflow
Uploaded corona/vnimage.payload
Uploaded corona/corona.tgz
Uploaded corona/cleanup
Uploaded corona/com.apple.ipsec.plist
Uploaded corona/Cydia.tgz
Uploaded corona/filemover
Uploaded corona/filemover.plist
Uploaded corona/gzip
Uploaded corona/jailbreak
Uploaded corona/jailbreak.mobileconfig
Uploaded corona/jb.plist
Uploaded corona/racoon-exploit-bootstrap.conf
Uploaded corona/tar
Creating backup...
69 files backed up
Adding custom com.apple.ipsec.plist to backup
Restoring...
1 files restored

Now use "cinject -w" to start watching the syslog.
Then toggle VPN on and look for the "pod2g is in da house!" syslog message.

% cinject -w

========================
ASL is here to serve you
> 
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: Could not prepare statement DROP TABLE WifiLocationBoxes, error code = 1, error message = no such table: WifiLocationBoxes
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: Could not prepare statement DROP TABLE WifiLocationLocal, error code = 1, error message = no such table: WifiLocationLocal
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: Could not prepare statement DROP TABLE WifiLocationLocalCounts, error code = 1, error message = no such table: WifiLocationLocalCounts
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: Could not prepare statement DROP TABLE WifiLocationLocalBoxes, error code = 1, error message = no such table: WifiLocationLocalBoxes
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: Could not prepare statement DROP TABLE CellLocationHarvest, error code = 1, error message = no such table: CellLocationHarvest
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: Could not prepare statement DROP TABLE CellLocationHarvestCounts, error code = 1, error message = no such table: CellLocationHarvestCounts
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: Could not prepare statement DROP TABLE CdmaCellLocationHarvest, error code = 1, error message = no such table: CdmaCellLocationHarvest
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: Could not prepare statement DROP TABLE CdmaCellLocationHarvestCounts, error code = 1, error message = no such table: CdmaCellLocationHarvestCounts
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: Could not prepare statement DROP TABLE WifiLocationHarvest, error code = 1, error message = no such table: WifiLocationHarvest
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: Could not prepare statement DROP TABLE WifiLocationHarvestCounts, error code = 1, error message = no such table: WifiLocationHarvestCounts
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: Could not prepare statement DROP TABLE LocationHarvest, error code = 1, error message = no such table: LocationHarvest
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: Could not prepare statement DROP TABLE LocationHarvestCounts, error code = 1, error message = no such table: LocationHarvestCounts
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: Could not prepare statement DROP TABLE Cell, error code = 1, error message = no such table: Cell
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: Could not prepare statement DROP TABLE Wifi, error code = 1, error message = no such table: Wifi
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: Could not prepare statement DROP TABLE Location, error code = 1, error message = no such table: Location
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: Could not prepare statement DROP TABLE CompassSettings, error code = 1, error message = no such table: CompassSettings
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: Could not prepare statement UPDATE Fences SET LastStatus = -1, error code = 1, error message = no such table: Fences
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: NOTICE,Deleting /var/root/Library/Caches/locationd/cells.plist if present
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: NOTICE,Deleting /var/root/Library/Caches/locationd/cells-local.plist if present
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: NOTICE,Deleting /var/root/Library/Caches/locationd/h-cells.plist if present
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: NOTICE,Deleting /var/root/Library/Caches/locationd/h-wifis.plist if present
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: NOTICE,Deleting /var/root/Library/Caches/locationd/clients-b.plist if present
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: NOTICE,Deleting /var/root/Library/Caches/locationd/c-trained.plist if present
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: NOTICE,Deleting /var/root/Library/Caches/locationd/cells.db if present
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: NOTICE,Deleting /var/root/Library/Caches/locationd/cells.db-journal if present
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: NOTICE,Deleting /var/root/Library/Caches/locationd/wifis.db if present
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: NOTICE,Deleting /var/root/Library/Caches/locationd/wifis.db-journal if present
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: NOTICE,Deleting /var/root/Library/Caches/locationd/cells-local.db if present
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: NOTICE,Deleting /var/root/Library/Caches/locationd/cells-local.db-journal if present
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: NOTICE,Deleting /var/root/Library/Caches/locationd/h-locations.db if present
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: NOTICE,Deleting /var/root/Library/Caches/locationd/h-locations.db-journal if present
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: NOTICE,Deleting /var/root/Library/Caches/locationd/h-cells.db if present
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: NOTICE,Deleting /var/root/Library/Caches/locationd/h-cells.db-journal if present
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: NOTICE,Deleting /var/root/Library/Caches/locationd/h-wifis.db if present
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: NOTICE,Deleting /var/root/Library/Caches/locationd/h-wifis.db-journal if present
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: NOTICE,Deleting /var/root/Library/Caches/locationd/compass.db if present
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: NOTICE,Deleting /var/root/Library/Caches/locationd/compass.db-journal if present
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: NOTICE,Deleting /var/root/Library/Caches/locationd/history.db if present
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: NOTICE,Deleting /var/root/Library/Caches/locationd/history.db-journal if present
Jan 21 02:11:12 unknown com.apple.locationd[48] <Notice>: NOTICE,Deleting /var/root/Library/Caches/locationd/glgps_nvs.bin if present
Jan 21 02:11:12 unknown com.apple.datamigrator[26] <Notice>: CoreLocation migration: succeeded
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: ... completed migration for CoreLocation and migrator com.apple.locationd.migrator (0.141684 s)
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: Beginning migration for CoreTime with migrator com.apple.timed.migrator; estimate is 0 seconds
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: ... completed migration for CoreTime and migrator com.apple.timed.migrator (0.00142205 s)
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: Beginning migration for da_accounts with migrator com.apple.dataaccess.migrator; estimate is 0.1 seconds
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: ... completed migration for da_accounts and migrator com.apple.dataaccess.migrator (0.095943 s)
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: Beginning migration for facetime-registration with migrator com.apple.facetime.migrator; estimate is 1 seconds
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: ... completed migration for facetime-registration and migrator com.apple.facetime.migrator (0.000553012 s)
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: Beginning migration for KeyboardMigrator with migrator com.apple.keyboards.migrator; estimate is 0.012 seconds
Jan 21 02:11:12 unknown profiled[74] <Notice>: (Note ) MC: Migrating passcode...
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: ... completed migration for KeyboardMigrator and migrator com.apple.keyboards.migrator (0.00542605 s)
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: Beginning migration for Maps with migrator com.apple.MapsDataClassMigrator.migrator; estimate is 1 seconds
Jan 21 02:11:12 unknown profiled[74] <Notice>: (Note ) MC: Completed migrating passcode.
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: Failed to migrate directions: (null)
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: ... completed migration for Maps and migrator com.apple.MapsDataClassMigrator.migrator (0.04792 s)
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: Beginning migration for mail with migrator com.apple.mobilemail.migrator; estimate is 0 seconds
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: ... completed migration for mail and migrator com.apple.mobilemail.migrator (0.148892 s)
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: Beginning migration for MobileNotes with migrator com.apple.MobileNotes.migrator; estimate is 1 seconds
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: ... completed migration for MobileNotes and migrator com.apple.MobileNotes.migrator (0.260773 s)
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: Beginning migration for MobileSlideShow with migrator com.apple.MobileSlideShow; estimate is 0 seconds
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: Failed to enumerate old iTunes videos paths at /var/mobile/Media/Photos/Videos [Migration will continue.] Error: Error Domain=NSCocoaErrorDomain Code=260 "The operation couldn-F¢t be completed. (Cocoa error 260.)" UserInfo=0xdd752f0 {NSFilePath=/var/mobile/Media/Photos/Videos, NSUnderlyingError=0xdd75260 "The operation couldn¢t be completed. No such file or directory"}-A
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: ... completed migration for MobileSlideShow and migrator com.apple.MobileSlideShow (0.018357 s)
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: Beginning migration for sms with migrator com.apple.sms.migrator; estimate is 0 seconds
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: ... completed migration for sms and migrator com.apple.sms.migrator (0.016135 s)
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: Beginning migration for springboard with migrator com.apple.sbmigrator; estimate is 0.2 seconds
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: ... completed migration for springboard and migrator com.apple.sbmigrator (0.00119603 s)
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: Beginning migration for sync_metadata with migrator com.apple.sync_metadata.migrator; estimate is 1 seconds
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: Sync data migrator detected old version
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: ... completed migration for sync_metadata and migrator com.apple.sync_metadata.migrator (0.012172 s)
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: Beginning migration for tone with migrator com.apple.tone.migrator; estimate is 1 seconds
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: ... completed migration for tone and migrator com.apple.tone.migrator (0.00319803 s)
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: Beginning migration for VoiceServices with migrator com.apple.voiceservices.migrator; estimate is 0 seconds
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: ... completed migration for VoiceServices and migrator com.apple.voiceservices.migrator (0.00114101 s)
Jan 21 02:11:12 unknown DataMigrator[26] <Warning>: Beginning migration for WebBookmarks with migrator com.apple.WebBookmarks.migrator; estimate is 1 seconds
Jan 21 02:11:12 unknown com.apple.datamigrator[26] <Notice>: Couldn't open shared capabilities memory GSCapabilities (No such file or directory)
Jan 21 02:11:12 unknown lockdownd[21] <Error>: 01a5f000 store_escrow_record: Creating escrow bag (hash=71ca47e8d7d57c877032e3b4afaa87821ee891bf) for BD13D3FA-AF37-40E2-A394-13420E7EDA21
Jan 21 02:11:13 unknown kernel[0] <Debug>: AppleH4CamIn::setPowerStateGated: 0
Jan 21 02:11:13 unknown kernel[0] <Debug>: AppleH4CamIn::power_off_hardware
Jan 21 02:11:13 unknown com.apple.datamigrator[26] <Notice>: Couldn't open shared capabilities memory GSCapabilities (No such file or directory)
Jan 21 02:11:13 unknown lockdownd[21] <Error>: 0195b000 copy_phonenumber: CTSettingCopyMyPhoneNumber() returned NULL
Jan 21 02:11:13 unknown lockdownd[21] <Error>: libMobileGestalt copyBasebandMobileEquipmentInfo: CommCenter error: 1:45
Jan 21 02:11:13 unknown lockdownd[21] <Error>: libMobileGestalt copyInternationalMobileEquipmentIdentity: Could not get mobile equipment info dictionary
Jan 21 02:11:13 unknown lockdownd[21] <Error>: 0195b000 copy_imei: MobileGestalt failed to provide an IMEI
Jan 21 02:11:13 unknown lockdownd[21] <Error>: 0195b000 copy_iccid: CommCenter error: 1:45
Jan 21 02:11:13 unknown lockdownd[21] <Error>: libMobileGestalt copyBasebandMobileEquipmentInfo: CommCenter error: 1:45
Jan 21 02:11:13 unknown lockdownd[21] <Error>: libMobileGestalt copyMobileEquipmentIdentifier: Could not get mobile equipment info dictionary
Jan 21 02:11:13 unknown lockdownd[21] <Error>: 0195b000 copy_meid: MobileGestalt failed to provide an MEID but returned no error (?)
Jan 21 02:11:13 unknown SpringBoard[15] <Notice>: IOMobileFrameBufferGetMirroringCapability returning -536870201 via kIOMFBConnectMethod_GetMirroringCapability 
Jan 21 02:11:13 unknown DataMigrator[26] <Warning>: ... completed migration for WebBookmarks and migrator com.apple.WebBookmarks.migrator (0.766101 s)
Jan 21 02:11:13 unknown DataMigrator[26] <Warning>: Beginning migration for iTunes Store with migrator com.apple.iTunesStore.migrator; estimate is 1 seconds
Jan 21 02:11:13 unknown DataMigrator[26] <Warning>: ... completed migration for iTunes Store and migrator com.apple.iTunesStore.migrator (0.00181502 s)
Jan 21 02:11:13 unknown DataMigrator[26] <Warning>: Data migration complete; waiting 15 seconds.
Jan 21 02:11:13 unknown SpringBoard[15] <Warning>: Migration complete. (Elapsed time: 9.99 seconds)
Jan 21 02:11:13 unknown SpringBoard[15] <Warning>: No AppleBaseband service detected. Cellular data disabled.
Jan 21 02:11:13 unknown SpringBoard[15] <Error>: WiFi: Consulting "no-sdio-devices" property.
Jan 21 02:11:13 unknown SpringBoard[15] <Error>: WiFi: "no-sdio-devices" property not found.
Jan 21 02:11:13 unknown SpringBoard[15] <Warning>: lockdown says the device is: [Unactivated], state is 1
Jan 21 02:11:13 unknown SpringBoard[15] <Warning>: +[SBPushStore migratePushStore] Migrating push store: /var/mobile/Library/SpringBoard/PushStore
Jan 21 02:11:13 unknown SpringBoard[15] <Warning>: +[SBPushStore migratePushStore] Push store does not exist; no migration needed.
Jan 21 02:11:14 unknown SpringBoard[15] <Notice>: MultitouchHID: detection mode: 255->0 (deferring until bootloaded)
Jan 21 02:11:14 unknown lockdownd[21] <Error>: 0195b000 copy_phonenumber: CTSettingCopyMyPhoneNumber() returned NULL
Jan 21 02:11:14 unknown lockdownd[21] <Error>: libMobileGestalt copyBasebandMobileEquipmentInfo: CommCenter error: 1:45
Jan 21 02:11:14 unknown lockdownd[21] <Error>: libMobileGestalt copyInternationalMobileEquipmentIdentity: Could not get mobile equipment info dictionary
Jan 21 02:11:14 unknown lockdownd[21] <Error>: 0195b000 copy_imei: MobileGestalt failed to provide an IMEI
Jan 21 02:11:14 unknown lockdownd[21] <Error>: 0195b000 copy_iccid: CommCenter error: 1:45
Jan 21 02:11:14 unknown lockdownd[21] <Error>: libMobileGestalt copyBasebandMobileEquipmentInfo: CommCenter error: 1:45
Jan 21 02:11:14 unknown lockdownd[21] <Error>: libMobileGestalt copyMobileEquipmentIdentifier: Could not get mobile equipment info dictionary
Jan 21 02:11:14 unknown lockdownd[21] <Error>: 0195b000 copy_meid: MobileGestalt failed to provide an MEID but returned no error (?)
Jan 21 02:11:15 unknown lockdownd[21] <Error>: 00420000 spawn_service_agent: Service com.apple.mobile.installation_proxy is currently prohibited from running
Jan 21 02:11:15 unknown lockdownd[21] <Error>: 00420000 spawn_and_handle_checkin: Could not spawn the com.apple.mobile.installation_proxy service agent:ServiceProhibited 
Jan 21 02:11:16 unknown SpringBoard[15] <Warning>: Reply Error: Connection invalid
Jan 21 02:11:16 unknown SpringBoard[15] <Warning>: BTM: attaching to BTServer
Jan 21 02:11:16 unknown aggregated[59] <Warning>: PLAggregateState Error: Leaving state screen_off even though we are not in it, doing nothing
Jan 21 02:11:16 unknown aggregated[59] <Warning>: PLAggregateState Error: Entering state screen_on even though we are already in it, doing nothing
Jan 21 02:11:16 unknown wifid[29] <Error>: WiFi:[348833476.981872]: Disable WoW requested by "spd"
Jan 21 02:11:17 unknown lockdownd[21] <Error>: 00420000 determine_activation_state_old: The original activation state is Unactivated
Jan 21 02:11:17 unknown lockdownd[21] <Error>: 00420000 determine_activation_state_old: SIM status: kCTSIMSupportSIMStatusReady
Jan 21 02:11:17 unknown lockdownd[21] <Error>: 00420000 determine_activation_state_old: Disabling the brick state
Jan 21 02:11:17 unknown lockdownd[21] <Error>: 00420000 determine_activation_state_old: Setting the activation state to Activated
Jan 21 02:11:17 unknown lockdownd[21] <Error>: 00420000 store_activation_record: Storing the iPod activation record
Jan 21 02:11:17 unknown SpringBoard[15] <Warning>: lockdown says the device is: [Activated], state is 3
Jan 21 02:11:17 unknown SpringBoard[15] <Warning>: lockdown says the device is: [Activated], state is 3
Jan 21 02:11:17 unknown SpringBoard[15] <Warning>: BTM: posting notification BluetoothAvailabilityChangedNotification
Jan 21 02:11:17 unknown lockdownd[21] <Error>: 00420000 handle_activate: Storing the necessary certificate in the checkpoint domain
Jan 21 02:11:17 unknown SpringBoard[15] <Warning>: BTM: BTLocalDeviceGetPairedDevices returned 0 devices
Jan 21 02:11:17 unknown lockdownd[21] <Error>: 00420000 copy_phonenumber: CTSettingCopyMyPhoneNumber() returned NULL
Jan 21 02:11:17 unknown lockdownd[21] <Error>: libMobileGestalt copyBasebandMobileEquipmentInfo: CommCenter error: 1:45
Jan 21 02:11:17 unknown lockdownd[21] <Error>: libMobileGestalt copyInternationalMobileEquipmentIdentity: Could not get mobile equipment info dictionary
Jan 21 02:11:17 unknown lockdownd[21] <Error>: 00420000 copy_imei: MobileGestalt failed to provide an IMEI
Jan 21 02:11:17 unknown lockdownd[21] <Error>: 00420000 copy_iccid: CommCenter error: 1:45
Jan 21 02:11:17 unknown lockdownd[21] <Error>: libMobileGestalt copyBasebandMobileEquipmentInfo: CommCenter error: 1:45
Jan 21 02:11:17 unknown lockdownd[21] <Error>: libMobileGestalt copyMobileEquipmentIdentifier: Could not get mobile equipment info dictionary
Jan 21 02:11:17 unknown lockdownd[21] <Error>: 00420000 copy_meid: MobileGestalt failed to provide an MEID but returned no error (?)
Jan 21 02:11:17 unknown SpringBoard[15] <Error>: WiFi: Consulting "no-sdio-devices" property.
Jan 21 02:11:17 unknown SpringBoard[15] <Error>: WiFi: "no-sdio-devices" property not found.
Jan 21 02:11:17 unknown lockdownd[21] <Error>: 00420000 set_language: Prepending the language list with en
Jan 21 02:11:17 unknown SpringBoard[15] <Warning>: SMS Plugin initialized.
Jan 21 02:11:17 unknown SpringBoard[15] <Warning>: Telephony plugin initialized
Jan 21 02:11:17 unknown lockdownd[21] <Error>: 00420000 set_keyboard: Could not load keyboards list
Jan 21 02:11:17 unknown lockdownd[21] <Error>: 00420000 set_keyboard: Creating the keyboard list with en_US
Jan 21 02:11:17 unknown SpringBoard[15] <Warning>: SIMToolkit plugin for SpringBoard initialized.
Jan 21 02:11:17 unknown SpringBoard[15] <Error>: WiFi: Consulting "no-sdio-devices" property.
Jan 21 02:11:17 unknown SpringBoard[15] <Error>: WiFi: "no-sdio-devices" property not found.
Jan 21 02:11:17 unknown SpringBoard[15] <Warning>: WiFi picker plugin initialized
Jan 21 02:11:17 unknown atc[58] <Warning>: Error: Connection invalid
Jan 21 02:11:18 unknown Setup[79] <Warning>: Setup Assistant Location: countries from defaults = '(null)'
Jan 21 02:11:18 unknown Setup[79] <Warning>: Setup Assistant Location: country from Telephony = ''
Jan 21 02:11:18 unknown Setup[79] <Warning>: Setup Assistant Location: started wifi scan
Jan 21 02:11:18 unknown wifid[29] <Error>: WiFi:[348833478.047291]: multi-stage auto-join: Error scanning for previous network, err=-3900
Jan 21 02:11:18 unknown kernel[0] <Debug>: launchd[81] Builtin profile: MobileMail (sandbox)
Jan 21 02:11:18 unknown wifid[29] <Error>: WiFi:[348833478.078533]: multi-stage auto-join: Error scanning for previous network, err=-3900
Jan 21 02:11:19 unknown softwareupdated[38] <Notice>: 3f632ce8 : Cleaning up unused prepared updates
Jan 21 02:11:20 unknown SpringBoard[15] <Warning>: EKAlarmEngine: Region monitoring not available or enabled. Trigger ignored!
Jan 21 02:11:20 unknown SpringBoard[15] <Warning>: [Warning] The RowID is out of bounds.  We were asked for rows after [0] which exceeds the current sequence number [-1]
Jan 21 02:11:21 unknown mstreamd[44] <Notice>: (Note ) mstreamd: No jobs scheduled.
Jan 21 02:11:21 unknown mstreamd[44] <Notice>: (Note ) mstreamd: Media stream daemon stopping.
Jan 21 02:11:21 unknown mstreamd[44] <Notice>: (Note ) mstreamd: mstreamd shutting down.
Jan 21 02:11:21 unknown Setup[79] <Warning>: Setup Assistant Location: Wifi scan guessed countries: '(
	    US
	)'
Jan 21 02:11:26 unknown timed[32] <Notice>: (Error) CoreTime: Can't set time zone to nil!
Jan 21 02:11:28 unknown wifid[29] <Error>: WiFi:[348833488.192200]: multi-stage auto-join: Error scanning for previous network, err=-3900
Jan 21 02:11:28 unknown Setup[79] <Warning>: loadAPTableCellImages: loading images
Jan 21 02:11:28 unknown timed[87] <Notice>: (Note ) CoreTime: Cache is empty.
Jan 21 02:11:29 unknown assetsd[28] <Notice>: PLModelMigrator: We are beginning file system import
Jan 21 02:11:29 unknown assetsd[28] <Notice>: PLModelMigrator: We have finished file system import
Jan 21 02:11:31 unknown timed[87] <Notice>: (Note ) CoreTime: Want active time in -0.00hrs. Need active time in -0.00hrs.
Jan 21 02:11:37 unknown wifid[29] <Error>: WiFi:[348833497.025698]: multi-stage auto-join: Error scanning for previous network, err=-3900
Jan 21 02:11:38 unknown OTACrashCopier[88] <Notice>: (Warn ) <OTAConditionMonitor.m -[OTAConditionMonitor _readDateFromMarkerFile:]:246> Failed to read attributes from '/var/mobile/Library/OTALogging/.last_attempted_submission_marker'
Jan 21 02:11:38 unknown OTACrashCopier[88] <Notice>: (Warn ) <OTAConditionMonitor.m -[OTAConditionMonitor _readDateFromMarkerFile:]:246> Failed to read attributes from '/var/mobile/Library/OTALogging/.last_successful_submission_marker'
Jan 21 02:11:38 unknown OTACrashCopier[88] <Notice>: (Warn ) <OTACrashCopierController.m -[OTACrashCopierController _cancelPendingSubmissions]:535> Cancelling all outstanding submission jobs
Jan 21 02:11:39 unknown wifid[29] <Error>: WiFi:[348833499.178106]: multi-stage auto-join: Error scanning for previous network, err=-3900
Jan 21 02:11:41 unknown timed[87] <Notice>: (Error) CoreTime: Can't set time zone to nil!
Jan 21 02:12:28 unknown profiled[74] <Notice>: (Note ) profiled: Idled.
Jan 21 02:12:28 unknown profiled[74] <Notice>: (Note ) profiled: Service stopping.
Jan 21 02:13:39 unknown SpringBoard[15] <Notice>: Posting 'com.apple.iokit.hid.displayStatus' notifyState=0
Jan 21 02:13:39 unknown SpringBoard[15] <Notice>: MultitouchHID: detection mode: 0->255
Jan 21 02:14:59 unknown SpringBoard[15] <Notice>: Posting 'com.apple.iokit.hid.displayStatus' notifyState=1
Jan 21 02:14:59 unknown SpringBoard[15] <Notice>: MultitouchHID: detection mode: 255->0 (deferring until bootloaded)
Jan 21 02:14:59 unknown SpringBoard[15] <Notice>: MultitouchHID: device bootloaded
Jan 21 02:14:59 unknown SpringBoard[15] <Notice>: MultitouchHID: detection mode: 0->0
Jan 21 02:15:00 unknown kernel[0] <Debug>: set_crc_notification_state 0
Jan 21 02:15:00 unknown wifid[29] <Error>: WiFi:[348833700.729114]: Client itunesstored is background application
Jan 21 02:16:48 unknown notification_proxy[78] <Error>: Could not receive size of message: 0 Invalid argument
Jan 21 02:16:48 unknown notification_proxy[78] <Error>: Could not receive message
Jan 21 02:16:48 unknown SpringBoard[15] <Warning>: Error: Connection interrupted
Jan 21 02:16:49 unknown mc_mobile_tunnel[105] <Notice>: (Note ) MC: mc_mobile_tunnel starting.
Jan 21 02:16:49 unknown mc_mobile_tunnel[105] <Notice>: (Note ) MC: mc_mobile_tunnel shutting down.
Jan 21 02:16:54 unknown mc_mobile_tunnel[106] <Notice>: (Note ) MC: mc_mobile_tunnel starting.
Jan 21 02:16:54 unknown mc_mobile_tunnel[106] <Notice>: (Note ) MC: mc_mobile_tunnel shutting down.
Jan 21 02:17:00 unknown SpringBoard[15] <Notice>: Posting 'com.apple.iokit.hid.displayStatus' notifyState=0
Jan 21 02:17:00 unknown SpringBoard[15] <Notice>: MultitouchHID: detection mode: 0->255
Jan 21 02:17:10 unknown mc_mobile_tunnel[108] <Notice>: (Note ) MC: mc_mobile_tunnel starting.
Jan 21 02:17:10 unknown profiled[109] <Notice>: (Note ) profiled: Service starting...
Jan 21 02:17:10 unknown profiled[109] <Notice>: (Note ) MC: Profile -Y´com.pod2g.jailbreak¡ queued for installation.
Jan 21 02:17:10 unknown SpringBoard[15] <Notice>: Posting 'com.apple.iokit.hid.displayStatus' notifyState=1
Jan 21 02:17:10 unknown SpringBoard[15] <Notice>: MultitouchHID: detection mode: 255->0 (deferring until bootloaded)
Jan 21 02:17:10 unknown mc_mobile_tunnel[108] <Notice>: (Note ) MC: mc_mobile_tunnel shutting down.
Jan 21 02:17:10 unknown SpringBoard[15] <Notice>: MultitouchHID: device bootloaded
Jan 21 02:17:10 unknown SpringBoard[15] <Notice>: MultitouchHID: detection mode: 0->0
Jan 21 02:17:10 unknown Preferences[111] <Warning>: Splitview controller <PSSplitViewController: 0xfe735b0> is expected to have a master view controller before its used!
Jan 21 02:17:11 unknown Preferences[111] <Warning>: BTM: attaching to BTServer
Jan 21 02:17:11 unknown kernel[0] <Debug>: set_crc_notification_state 0
Jan 21 02:17:11 unknown Preferences[111] <Warning>: BTM: posting notification BluetoothAvailabilityChangedNotification
Jan 21 02:17:13 unknown profiled[109] <Notice>: (Note ) MC: Checking for MDM installation...
Jan 21 02:17:13 unknown profiled[109] <Notice>: (Note ) MC: ...finished checking for MDM installation.
Jan 21 02:17:13 unknown profiled[109] <Notice>: (Note ) MC: Beginning profile installation...
Jan 21 02:17:16 unknown Preferences[111] <Warning>: -[VPNConnectionStore reloadVPN]: The active VPN configuration has changed from (null) to 277BDCDF-7695-4926-ADB0-185B959A43C5
Jan 21 02:17:16 unknown configd[14] <Notice>: network configuration changed.
Jan 21 02:17:16 unknown Preferences[111] <Warning>: -[VPNBundleController _vpnConfigurationChanged:] (0xfe8c850:<VPNBundleController: 0xfe8c850>): _serviceCount(0), serviceCount(1), toggleInRootMenu(0), RootMenuItem(1)
Jan 21 02:17:16 unknown Preferences[111] <Warning>: -[VPNBundleController _vpnConfigurationChanged:]: Attemping to insert VPN specifier in root menu at index: 3
Jan 21 02:17:16 unknown profiled[109] <Notice>: (Note ) MC: Profile ´com.pod2g.jailbreak¡ installed.
Jan 21 02:17:16 unknown Preferences[111] <Warning>: -[VPNBundleController _vpnConfigurationChanged:] (0xfe8c850:<VPNBundleController: 0xfe8c850>): _serviceCount(1), serviceCount(1), toggleInRootMenu(1), RootMenuItem(1)
Jan 21 02:17:28 unknown mc_mobile_tunnel[116] <Notice>: (Note ) MC: mc_mobile_tunnel starting.
Jan 21 02:17:29 unknown BackupAgent2[119] <Error>: -[__NSCFConstantString containsObject:]: unrecognized selector sent to instance 0x3f95f9d0
Jan 21 02:17:29 unknown BackupAgent2[119] <Error>: *** Terminating app due to uncaught exception 'NSInvalidArgumentException', reason: '-[__NSCFConstantString containsObject:]: unrecognized selector sent to instance 0x3f95f9d0'
	*** First throw call stack:
	(0x37d518bf 0x3789d1e5 0x37d54acb 0x37d53945 0x37cae680 0xd7b7d 0xd7f55 0x309d68bb 0x309db969 0x37d1c555 0x37d25553 0x37d254f5 0x37d24343 0x37ca74dd 0x37d2447b 0xd86cd 0xd6a25 0xb9ff4)
Jan 21 02:17:30 unknown ReportCrash[120] <Notice>: Formulating crash report for process BackupAgent2[119]
Jan 21 02:17:30 unknown ReportCrash[120] <Error>: Saved crashreport to /Library/Logs/CrashReporter/BackupAgent2_2012-01-21-021729_iPad.plist using uid: 0 gid: 0, synthetic_euid: 0 egid: 0
Jan 21 02:17:34 unknown BackupAgent2[142] <Warning>: WARNING: Starting backup
Jan 21 02:17:34 unknown BackupAgent2[142] <Warning>: INFO: DeviceID="8575116f7741ec9eb7ed5be01f74115da96468c4", DeviceName="iPad", ProductType="iPad2,1", BuildVersion="9A405"
Jan 21 02:17:34 unknown BackupAgent2[142] <Warning>: INFO: Backup status: <MBStatus: version=0.0, date=(null), backupState=old, snapshotState=uploading, fullBackup=0>
Jan 21 02:17:34 unknown BackupAgent2[142] <Warning>: INFO: Creating keybag
Jan 21 02:17:34 unknown BackupAgent2[142] <Warning>: INFO: Performing a full backup
Jan 21 02:17:35 unknown BackupAgent2[142] <Warning>: INFO: Scanned in 0.652 s
Jan 21 02:17:35 unknown BackupAgent2[142] <Warning>: INFO: File modified while being uploaded (mod time changed): /var/mobile/Library/Calendar/Extras.db (22b5fb3c3890cfc5cee685c923922e8ebe8ee9fd)
Jan 21 02:17:35 unknown BackupAgent2[142] <Warning>: INFO: Uploaded 61 files of 5.0 MB in 0.872 s at 5.72 MB/s
Jan 21 02:17:35 unknown BackupAgent2[142] <Warning>: INFO: Retrying backup (attempt 1 of 3, modified domains: {HomeDomain})
Jan 21 02:17:37 unknown BackupAgent2[142] <Warning>: INFO: Scanned in 1.039 s
Jan 21 02:17:37 unknown BackupAgent2[142] <Warning>: INFO: Uploaded 1 files of 28.0 KB in 0.089 s at 0.31 MB/s
Jan 21 02:17:37 unknown BackupAgent2[142] <Warning>: INFO: Moved 61 files in 0.081 s
Jan 21 02:17:37 unknown BackupAgent2[142] <Warning>: INFO: Removed 0 items in 0.016 s
Jan 21 02:17:37 unknown BackupAgent2[142] <Warning>: WARNING: Finished backup in 2.873 s
Jan 21 02:17:37 unknown BackupAgent2[143] <Warning>: WARNING: Starting restore from 8575116f7741ec9eb7ed5be01f74115da96468c4
Jan 21 02:17:37 unknown BackupAgent2[143] <Warning>: INFO: DeviceID="8575116f7741ec9eb7ed5be01f74115da96468c4", DeviceName="iPad", ProductType="iPad2,1", BuildVersion="9A405"
Jan 21 02:17:37 unknown profiled[109] <Notice>: (Warn ) profiled: Received notification that a backup is about to run. Shutting down.
Jan 21 02:17:37 unknown profiled[109] <Notice>: (Note ) profiled: Idled.
Jan 21 02:17:37 unknown profiled[109] <Notice>: (Note ) profiled: Service stopping.
Jan 21 02:17:37 unknown BackupAgent2[143] <Warning>: INFO: Starting to retrieve previous backup status
Jan 21 02:17:37 unknown BackupAgent2[143] <Warning>: INFO: Backup status: <MBStatus: version=2.4, date=2012-01-21 10:17:37 +0000, backupState=new, snapshotState=finished, fullBackup=0>
Jan 21 02:17:37 unknown BackupAgent2[143] <Warning>: INFO: Backup properties: <MBDriveProperties: version=9.0, systemDomainsVersion=12.0, date=2012-01-21 10:17:36 +0000, encrypted=0, passcodeSet=0, lockdownKeys={UniqueDeviceID: "8575116f7741ec9eb7ed5be01f74115da96468c4", com.apple.TerminalFlashr: {}, com.apple.mobile.data_sync: {}, BuildVersion: "9A405", com.apple.mobile.iTunes.accessories: {}, DeviceName: "iPad", com.apple.mobile.wireless_lockdown: {}, SerialNumber: "DQTFWYN9DFHW", com.apple.MobileDeviceCrashCopy: {ShouldSubmitVersion: 1, ShouldSubmit: 0}, com.apple.iTunes.backup: {}, com.apple.Accessibility: {VoiceOverTouchEnabledByiTunes: 0}, com.apple.itunesstored: {AccountSocialEnabled: 0, AccountServiceTypes: 0, AccountURLBagType: "production", AccountAvailableServiceTypes: 0, AccountKind: 0, AppleID: "musclenerd", DSPersonID: 28532949}, ProductType: "iPad2,1", ProductVersion: "5.0.1"}>
Jan 21 02:17:37 unknown BackupAgent2[143] <Warning>: INFO: Backup database: <MBDatabase: version=5.0>
Jan 21 02:17:37 unknown BackupAgent2[143] <Warning>: INFO: Finished retrieving previous backup status in 0.054 s
Jan 21 02:17:37 unknown BackupAgent2[143] <Warning>: INFO: Starting to prepare for restore
Jan 21 02:17:37 unknown BackupAgent2[143] <Warning>: INFO: Backup is unencrypted
Jan 21 02:17:37 unknown BackupAgent2[143] <Warning>: INFO: Expected duration: 0.890 s
Jan 21 02:17:37 unknown BackupAgent2[143] <Warning>: INFO: Starting to copy backup with 0 files of size 0 B
Jan 21 02:17:37 unknown BackupAgent2[143] <Warning>: INFO: Finished copying backup in 0.152 s at 0.00 MB/s
Jan 21 02:17:37 unknown BackupAgent2[143] <Warning>: INFO: Finished preparing for restore in 0.381 s
Jan 21 02:17:37 unknown BackupAgent2[143] <Warning>: INFO: Starting to restore 62 files of size 6.2 MB
Jan 21 02:17:39 unknown BackupAgent2[143] <Warning>: INFO: Finished restoring files in 1.175 s at 5.29 MB/s
Jan 21 02:17:39 unknown BackupAgent2[143] <Warning>: INFO: Starting to remove items not restored
Jan 21 02:17:39 unknown BackupAgent2[143] <Warning>: INFO: Finished removing items not restored in 0.020 s
Jan 21 02:17:39 unknown BackupAgent2[143] <Warning>: INFO: Starting to restore directory modification times
Jan 21 02:17:39 unknown BackupAgent2[143] <Warning>: INFO: Finished restoring directory modification times in 0.015 s
Jan 21 02:17:39 unknown BackupAgent2[143] <Warning>: INFO: Starting to process 0 restored apps
Jan 21 02:17:39 unknown BackupAgent2[143] <Warning>: INFO: Finished processing restored apps in 0.000 s
Jan 21 02:17:39 unknown BackupAgent2[143] <Warning>: WARNING: Finished restore in 2.004 s
Jan 21 02:17:39 unknown mc_mobile_tunnel[116] <Notice>: (Note ) MC: mc_mobile_tunnel shutting down.
> 
Jan 21 02:17:51 iPad configd[14] <Notice>: IPSec connecting to server 127.0.0.1
Jan 21 02:17:51 iPad configd[14] <Notice>: IPSec Phase1 starting.
Jan 21 02:17:51 iPad configd[14] <Notice>: SCNC: start, triggered by Preferences, type IPSec, status 0
Jan 21 02:17:52 iPad racoon[146] <Error>: __SCPreferencesAccess CFPropertyListCreateWithData(): The operation couldn-F-F¢t be completed. (Cocoa error 3840.)-A
Jan 21 02:17:52 iPad kernel[0] <Debug>: launchd[146] Builtin profile: racoon (sandbox)
Jan 21 02:17:56 iPad racoon[146] <Warning>: Entering racoon ROP.
Jan 21 02:17:56 iPad racoon[146] <Warning>: shmBaseAddress: 1bef00
Jan 21 02:17:56 iPad racoon[146] <Warning>: notifyd pid: 13
Jan 21 02:17:56 iPad racoon[146] <Warning>: Looked up notification center: 0x1203
Jan 21 02:17:56 iPad racoon[146] <Warning>: attached to notifyd
Jan 21 02:17:56 iPad racoon[146] <Warning>: sleeping...
Jan 21 02:17:57 iPad racoon[146] <Warning>: continuing...
Jan 21 02:17:57 iPad racoon[146] <Warning>: detached!!!
Jan 21 02:17:57 iPad racoon[146] <Warning>: sleeping...
Jan 21 02:17:58 iPad racoon[146] <Warning>: Local port: 0x1703
Jan 21 02:17:58 iPad racoon[146] <Warning>: attached to notifyd
Jan 21 02:17:58 iPad racoon[146] <Warning>: sleeping...
Jan 21 02:17:59 iPad racoon[146] <Warning>: continuing...
Jan 21 02:17:59 iPad racoon[146] <Warning>: detached!!!
Jan 21 02:17:59 iPad racoon[146] <Warning>: sleeping...
Jan 21 02:18:00 iPad racoon.log[149] <Error>: __SCPreferencesAccess CFPropertyListCreateWithData(): The operation couldn-F¢t be completed. (Cocoa error 3840.)-A
Jan 21 02:18:00 iPad kernel[0] <Debug>: missing or invalid entitlement hash
Jan 21 02:18:00 iPad racoon[146] <Warning>: Racoon ROP ended.
Jan 21 02:18:00 iPad com.apple.launchd[1] (com.apple.racoon) <Warning>: (com.apple.racoon) Throttling respawn: Will start in 1 seconds
Jan 21 02:18:01 iPad configd[14] <Notice>: IPSec disconnecting from server 127.0.0.1
Jan 21 02:18:01 iPad configd[14] <Error>: SCNC Controller: service_ending_verify_primaryservice, waiting for PrimaryService. status = 1.
Jan 21 02:18:02 iPad racoon[151] <Error>: __SCPreferencesAccess CFPropertyListCreateWithData(): The operation couldn-F¢t be completed. (Cocoa error 3840.)-A
Jan 21 02:18:02 iPad racoon[151] <Notice>: IPSec disconnecting from server 127.0.0.1
Jan 21 02:18:02 iPad racoon[151] <Notice>: IPSec disconnecting from server 127.0.0.1
Jan 21 02:18:02 iPad kernel[0] <Debug>: launchd[151] Builtin profile: racoon (sandbox)
Jan 21 02:18:02 iPad racoon.log[149] <Warning>: * Remounting root read-write...
Jan 21 02:18:02 iPad racoon.log[149] <Warning>: * mount returned: 0
Jan 21 02:18:02 iPad racoon.log[149] <Warning>: * Starting kernel exploit...
Jan 21 02:18:02 iPad kernel[0] <Error>: 
Jan 21 02:18:02 iPad kernel[0] <Error>: 
Jan 21 02:18:02 iPad racoon.log[149] <Warning>: * Finished. Executing hello.
Jan 21 02:18:02 iPad jailbreak[149] <Warning>: Begining jailbreak executable...
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/source.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Swedish.lproj/
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Swedish.lproj/Localizable.strings
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/installed.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/configure.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Italian.lproj/
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Italian.lproj/Localizable.strings
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Info.plist
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/folder.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/reload.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Default@2x.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/German.lproj/
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/German.lproj/Sections.strings
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/German.lproj/Localizable.strings
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/MobileCydia
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Default.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/home@2x.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/source@2x.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/folder@2x.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/search.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/iconClassic.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/install.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Icon-Small.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/installing.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/unknown.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Icon-Small@2x.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/zh_TW.lproj/
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/zh_TW.lproj/Localizable.strings
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections.plist
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/sources.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Multimedia.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Site-Specific_Apps.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Security.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Terminal_Support.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Packaging.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Scripting.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Networking.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Ringtones.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Planet-iPhones Mods.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Productivity.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Text_Editors.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Tweaks.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Dictionaries.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Social.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Books.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Carrier_Bundles.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Addons.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/WebClips.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Communication.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Blanks.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Education.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Utilities.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Games.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Entertainment.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Messaging.png
Jan 21 02:18:02 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Repositories.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Navigation.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Widgets.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Toys.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/System.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Development.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Health_and_Fitness.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Archiving.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Wallpaper.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Soundboards.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Keyboards.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Data_Storage.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Imaging.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Localization.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Fonts.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Java.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Themes.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/Administration.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Sections/X_Window.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Purposes/
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Purposes/commercial.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Purposes/extension.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Purposes/library.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Purposes/console.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Purposes/daemon.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Purposes/uikit.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Purposes/x.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Cydia
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Dutch.lproj/
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Dutch.lproj/Localizable.strings
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/storage.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Sources/
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Sources/apt.bigboss.us.com.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/packages.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/icon@2x.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/manage.html
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/search@2x.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Icon-Small-50.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/French.lproj/
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/French.lproj/Sections.strings
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/French.lproj/Localizable.strings
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/icon-72.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/changes@2x.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/menes/
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/menes/menes.js
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/home-Selected.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/chevron@2x.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/home.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/install@2x.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/manage@2x.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Default-Portrait.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/changes.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/zh_CN.lproj/
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/zh_CN.lproj/Localizable.strings
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/installed@2x.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/English.lproj/
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/English.lproj/Sections_.strings
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/English.lproj/Localizable.strings
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/error.html
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/compose.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/el.lproj/
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/el.lproj/Sections.strings
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/el.lproj/Localizable.strings
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Default-Landscape.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/home-Selected@2x.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/manage.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/localize.js
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/removing.png
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Spanish.lproj/
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/Spanish.lproj/Localizable.strings
Jan 21 02:18:03 iPad jb[149] <Notice>: Applications/Cydia.app/icon.png
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/chmod
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/dir
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/chown
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/kill
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/chgrp
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/uname
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/bzcat
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/bunzip2
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/zdiff
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/readlink
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/zgrep
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/egrep
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/stty
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/ln
Jan 21 02:18:03 iPad kernel[0] <Debug>: pod2g is in da house !
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/su
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/date
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/fgrep
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/sed
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/tar
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/false
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/ls
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/bash
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/zcmp
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/run-parts
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/echo
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/zcat
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/gzip
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/vdir
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/zforce
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/cat
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/sleep
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/sync
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/mv
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/bzip2recover
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/rm
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/mkdir
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/pwd
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/rmdir
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/dd
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/mknod
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/mktemp
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/true
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/bzip2
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/zfgrep
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/zegrep
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/gunzip
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/df
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/grep
Jan 21 02:18:03 iPad jb[149] <Notice>: bin/uncompress
Jan 21 02:18:04 iPad lockdownd[21] <Error>: 01753000 _receive_message: walk away - non-SSL 1
Jan 21 02:18:04 iPad com.apple.mobile.lockdown[21] <Notice>: receive secure message timeout!
Jan 21 02:18:04 iPad jb[149] <Notice>: bin/touch
Jan 21 02:18:04 iPad jb[149] <Notice>: bin/zmore
Jan 21 02:18:04 iPad jb[149] <Notice>: bin/gzexe
Jan 21 02:18:04 iPad jb[149] <Notice>: bin/cp
Jan 21 02:18:04 iPad jb[149] <Notice>: bin/sh
Jan 21 02:18:04 iPad jb[149] <Notice>: bin/zless
Jan 21 02:18:04 iPad jb[149] <Notice>: bin/znew
Jan 21 02:18:04 iPad jb[149] <Notice>: boot/
Jan 21 02:18:04 iPad jb[149] <Notice>: dev/
Jan 21 02:18:04 iPad jb[149] <Notice>: etc
Jan 21 02:18:04 iPad jb[149] <Notice>: lib/
Jan 21 02:18:04 iPad jb[149] <Notice>: Library/
Jan 21 02:18:04 iPad jb[149] <Notice>: Library/Wallpaper/
Jan 21 02:18:04 iPad jb[149] <Notice>: Library/LaunchDaemons/
Jan 21 02:18:04 iPad jb[149] <Notice>: Library/LaunchAgents/
Jan 21 02:18:04 iPad jb[149] <Notice>: Library/Preferences
Jan 21 02:18:04 iPad jb[149] <Notice>: Library/Ringtones/
Jan 21 02:18:04 iPad jb[149] <Notice>: Library/Frameworks/
Jan 21 02:18:04 iPad jb[149] <Notice>: mnt/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/empty/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/logs/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/vm/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/cydia/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/misc/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/apt/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/apt/periodic/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/apt/lists/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/apt/lists/partial/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/grep.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/sed.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/org.thebigboss.repo.icons.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/ncurses.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/findutils.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/shell-cmds.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/tar.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/bash.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/darwintools.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/apr-lib.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/cydia.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/uikittools.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/gzip.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/apt7-lib.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/bzip2.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/diffutils.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/pam-modules.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/coreutils-bin.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/apt7-key.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/system-cmds.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/debianutils.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/cydia-lproj.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/lzma.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/readline.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/pcre.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/gnupg.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/profile.d.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/pam.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/base.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/firmware-sbin.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/info/dpkg.list
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/parts/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/alternatives/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/updates/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/status
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lib/dpkg/available
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/preferences/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/root/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/root/Media/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/local/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/lock/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/spool/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/stash/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/tmp/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/cache/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/cache/apt/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/cache/apt/archives/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/cache/apt/archives/partial/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/cache/findutils/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/run/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/run/utmp
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/db/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/backups/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/log/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/log/apt/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/mobile/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/mobile/Library/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/mobile/Library/Preferences/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/mobile/Media/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/var/msgs/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/etc/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/etc/pam.d/
Jan 21 02:18:04 iPad jb[149] <Notice>: private/etc/pam.d/sshd
Jan 21 02:18:04 iPad jb[149] <Notice>: private/etc/pam.d/sudo
Jan 21 02:18:04 iPad jb[149] <Notice>: private/etc/pam.d/passwd
Jan 21 02:18:04 iPad jb[149] <Notice>: private/etc/pam.d/other
Jan 21 02:18:04 iPad jb[149] <Notice>: private/etc/pam.d/su
Jan 21 02:18:04 iPad jb[149] <Notice>: private/etc/pam.d/chkpasswd
Jan 21 02:18:04 iPad jb[149] <Notice>: private/etc/pam.d/login
Jan 21 02:18:04 iPad jb[149] <Notice>: private/etc/pam.d/samba
Jan 21 02:18:05 iPad jb[149] <Notice>: private/etc/alternatives/
Jan 21 02:18:05 iPad jb[149] <Notice>: private/etc/alternatives/README
Jan 21 02:18:05 iPad jb[149] <Notice>: private/etc/default/
Jan 21 02:18:05 iPad jb[149] <Notice>: private/etc/profile.d/
Jan 21 02:18:05 iPad jb[149] <Notice>: private/etc/profile.d/terminal.sh
Jan 21 02:18:05 iPad jb[149] <Notice>: private/etc/profile
Jan 21 02:18:05 iPad jb[149] <Notice>: private/etc/apt/
Jan 21 02:18:05 iPad jb[149] <Notice>: private/etc/apt/apt.conf.d/
Jan 21 02:18:05 iPad jb[149] <Notice>: private/etc/apt/sources.list.d/
Jan 21 02:18:05 iPad jb[149] <Notice>: private/etc/apt/sources.list.d/saurik.list
Jan 21 02:18:05 iPad jb[149] <Notice>: private/etc/apt/trusted.gpg.d/
Jan 21 02:18:05 iPad jb[149] <Notice>: private/etc/apt/trusted.gpg.d/bigboss.gpg
Jan 21 02:18:05 iPad jb[149] <Notice>: private/etc/apt/trusted.gpg.d/modmyi.gpg
Jan 21 02:18:05 iPad jb[149] <Notice>: private/etc/apt/trusted.gpg.d/zodttd.gpg
Jan 21 02:18:05 iPad jb[149] <Notice>: private/etc/apt/trusted.gpg.d/saurik.gpg
Jan 21 02:18:05 iPad jb[149] <Notice>: private/etc/apt/trustdb.gpg
Jan 21 02:18:05 iPad jb[149] <Notice>: private/etc/apt/trusted.gpg
Jan 21 02:18:05 iPad jb[149] <Notice>: private/etc/apt/preferences.d/
Jan 21 02:18:05 iPad jb[149] <Notice>: private/etc/dpkg/
Jan 21 02:18:05 iPad jb[149] <Notice>: private/etc/dpkg/origins/
Jan 21 02:18:05 iPad jb[149] <Notice>: private/etc/dpkg/origins/debian
Jan 21 02:18:05 iPad jb[149] <Notice>: sbin/
Jan 21 02:18:05 iPad jb[149] <Notice>: sbin/nologin
Jan 21 02:18:05 iPad jb[149] <Notice>: sbin/reboot
Jan 21 02:18:05 iPad jb[149] <Notice>: sbin/dynamic_pager
Jan 21 02:18:05 iPad jb[149] <Notice>: sbin/dmesg
Jan 21 02:18:05 iPad jb[149] <Notice>: sbin/halt
Jan 21 02:18:05 iPad jb[149] <Notice>: System/
Jan 21 02:18:05 iPad jb[149] <Notice>: System/Library/
Jan 21 02:18:05 iPad jb[149] <Notice>: System/Library/SystemConfiguration/
Jan 21 02:18:05 iPad jb[149] <Notice>: System/Library/Internet Plug-Ins/
Jan 21 02:18:05 iPad jb[149] <Notice>: System/Library/PrivateFrameworks/
Jan 21 02:18:05 iPad jb[149] <Notice>: System/Library/Extensions/
Jan 21 02:18:05 iPad jb[149] <Notice>: System/Library/LaunchDaemons/
Jan 21 02:18:05 iPad jb[149] <Notice>: System/Library/LaunchDaemons/com.saurik.Cydia.Startup.plist
Jan 21 02:18:05 iPad jb[149] <Notice>: System/Library/PreferenceBundles/
Jan 21 02:18:05 iPad jb[149] <Notice>: System/Library/Fonts/
Jan 21 02:18:05 iPad jb[149] <Notice>: System/Library/KeyboardDictionaries/
Jan 21 02:18:05 iPad jb[149] <Notice>: System/Library/Frameworks/
Jan 21 02:18:05 iPad jb[149] <Notice>: System/Library/VideoDecoders/
Jan 21 02:18:05 iPad jb[149] <Notice>: tmp
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/toe
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/lzcmp
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/time
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/tset
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/apt-key
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/reset
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/lzcat
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/renice
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/vm_stat
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/bashbug
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/lzma
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/sbreload
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/lzfgrep
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/passwd
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/zprint
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/getty
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/infotocap
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/tput
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/dirname
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/find
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/gpg
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/sw_vers
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/lzmore
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/uiduid
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/uicache
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/unlzma
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/diff3
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/tar
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/dpkg-split
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/sdiff
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/pcretest
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/chsh
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/lzmadec
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/getconf
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/dpkg-name
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/gpgsplit
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/gpg-zip
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/pcregrep
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/infocmp
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/hostinfo
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/dpkg-deb
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/sbdidlaunch
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/captoinfo
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/dpkg-query
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/lzless
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/chfn
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/xargs
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/dpkg-trigger
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/updatedb
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/which
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/dselect
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/script
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/login
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/uiopen
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/cmp
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/lzmainfo
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/diff
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/clear
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/gpgv
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/killall
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/dpkg
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/locate
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/lzegrep
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/gssc
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/tic
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/cfversion
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/ncursesw5-config
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/lzdiff
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/iomfsetgamma
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/arch
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/lzgrep
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/pagesize
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/ncurses5-config
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/bin/pcre-config
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/gnupg/
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/gnupg/options.skel
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/dict/
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/misc/
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/tabset/
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/tabset/vt300
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/tabset/vt100
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/tabset/std
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/tabset/stdcrt
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/r/
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/r/rxvt-88color
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/r/rxvt-xpm
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/r/rxvt-color
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/r/rxvt
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/r/rxvt-cygwin-native
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/r/rxvt-256color
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/r/rxvt-cygwin
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/r/rxvt-16color
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/r/rxvt-basic
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/m/
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/m/mach
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/m/mach-bold
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/m/mach-color
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/p/
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/p/pcansi-25-m
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/p/pcansi-43-m
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/p/pcansi-33-m
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/p/pcansi
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/p/pcansi-25
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/p/pcansi-m
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/p/pcansi-43
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/p/pcansi-33
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/p/pcansi-mono
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-xf86-v33
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-xf86-v333
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-xfree86
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-xf86-v32
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-xi
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-new
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-256color
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-sun
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-old
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-1002
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-88color
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-basic
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-xf86-v43
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-hp
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-xf86-v44
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-r6
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-color
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-1003
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-sco
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-bold
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-nic
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-r5
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-16color
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-pcolor
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-24
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-8bit
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-vt220
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-xf86-v40
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-vt52
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/x/xterm-noapp
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/c/
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/c/cons25-m
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/c/cons25-iso-m
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/c/cons25
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/c/cygwin
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/c/cons25-iso8859
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/c/cons25-koi8-r
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/c/cons25-koi8r-m
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/sun-48
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/screen-16color-bce
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/screen-256color-bce
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/sun-cgsix
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/screen-s
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/sun-ss5
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/screen-16color
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/sun-34
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/sun-il
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/sun-s
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/sun-color
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/sun-e
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/sun
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/screen-256color-bce-s
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/sun-12
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/sun-e-s
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/screen-bce
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/screen-256color
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/sun-cmd
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/sun-nic
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/sun-s-e
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/screen-16color-bce-s
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/screen-256color-s
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/sun-1
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/sun-17
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/screen
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/sun-24
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/sun-c
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/screen-w
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/sun-type4
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/s/screen-16color-s
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/E/
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/E/Eterm-88color
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/E/Eterm
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/E/Eterm-256color
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/E/Eterm-color
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/vt220-8bit
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/vt100-top-s
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/vt100-w-nav
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/vt100-nam-w
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/vt100-nam
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/vt100
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/vt220-8
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/vt102
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/vt100-nav-w
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/vt100-vb
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/vt100-s
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/vt100-w
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/vt100-putty
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/vt52
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/vt100-bm-o
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/vt102-w
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/vt220
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/vt102-nsgr
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/vt100-am
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/vt220-old
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/vt100-nav
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/vt100-s-bot
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/vt100-bm
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/vt220-w
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/vt220-js
Jan 21 02:18:05 iPad jb[149] <Notice>: usr/share/terminfo/v/vt100-bot-s
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/v/vt100-w-nam
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/v/vt220-nam
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/v/vt100-w-am
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/v/vt100-s-top
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/a/
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/a/ansi-nt
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/a/ansi-emx
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/a/ansi-mr
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/a/ansi-mono
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/a/ansi-mtabs
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/a/ansi
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/a/ansi-color-3-emx
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/a/ansi-m
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/a/ansi-generic
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/a/ansi-color-2-emx
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/a/ansi-mini
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/l/
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/l/linux
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/l/linux-c
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/l/linux-nic
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/l/linux-koi8
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/l/linux-basic
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/l/linux-koi8r
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/l/linux-m
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/l/linux-c-nc
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/l/linux-vt
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/l/linux-lat
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/d/
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/terminfo/d/dumb
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/dpkg/
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/dpkg/triplettable
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/dpkg/ostable
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/dpkg/cputable
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/dpkg/origins/
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/bigboss/
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/bigboss/icons/
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/bigboss/icons/bigboss.png
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/bigboss/icons/planetiphones.png
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/share/bigboss/icons/touchrev.png
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libpcre.0.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/pkgconfig/
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/pkgconfig/libpcrecpp.pc
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/pkgconfig/libpcre.pc
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/pkgconfig/apr-1.pc
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libapt-pkg.dylib.4.6.0
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libpcre.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libapt-inst.dylib.1.1
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libhistory.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libform.5.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libapt-inst.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libmenu.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libapr-1.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libpcrecpp.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libreadline.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libcurses.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libpam_misc.1.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libreadline.5.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libapt-pkg.dylib.4.6
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libpam.1.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libhistory.5.2.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libpanelw.5.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libhistory.6.0.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libpamc.1.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/liblzmadec.0.0.0.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libapt-pkg.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libncursesw.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libmenuw.5.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libformw.5.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libpcre.la
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libncurses.5.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libapr-1.la
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/liblzmadec.0.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libpcre.0.0.1.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/terminfo
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libpcrecpp.0.0.0.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libpcrecpp.la
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/_ncurses
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libmenuw.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/liblzmadec.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libreadline.6.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/liblzmadec.la
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/pam/
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/pam/pam_launchd.so
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/pam/pam_permit.so
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/pam/pam_uwtmp.so
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/pam/pam_securetty.so
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/pam/pam_unix.so
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/pam/pam_rootok.so
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/pam/pam_deny.so
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/pam/pam_wheel.so
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/pam/pam_nologin.so
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libapr-1.0.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libmenu.5.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libpam_misc.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libpcreposix.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libpcrecpp.0.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libncurses.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libapt-inst.dylib.1.1.0
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libhistory.6.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libpanel.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libpcreposix.0.0.0.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libpam.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libreadline.6.0.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libapr-1.0.3.3.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/apt/
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/apt/methods/
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/apt/methods/ftp
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/apt/methods/lzma
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/apt/methods/rsh
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/apt/methods/copy
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/apt/methods/gzip
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/apt/methods/rred
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/apt/methods/file
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/apt/methods/cdrom
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/apt/methods/bzip2
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/apt/methods/http
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/apt/methods/gpgv
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/apt/methods/ssh
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/dpkg/
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/dpkg/methods/
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/dpkg/methods/apt/
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/dpkg/methods/apt/setup
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/dpkg/methods/apt/names
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/dpkg/methods/apt/desc.apt
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/dpkg/methods/apt/install
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/dpkg/methods/apt/update
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libreadline.5.2.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libpanel.5.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libformw.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libpcreposix.la
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libpamc.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libhistory.5.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libform.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libpcreposix.0.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libpanelw.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libncursesw.5.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/libpam.1.0.dylib
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/lib/apr.exp
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/sbin/
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/sbin/zdump
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/sbin/sysctl
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/sbin/vipw
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/sbin/mkfile
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/sbin/zic
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/sbin/update
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/sbin/iostat
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/sbin/ac
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/sbin/vifs
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/sbin/pwd_mkdb
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/sbin/startupfiletool
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/sbin/accton
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/pcre_stringpiece.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/term.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/readline/
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/readline/tilde.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/readline/keymaps.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/readline/rltypedefs.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/readline/chardefs.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/readline/rlstdc.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/readline/history.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/readline/readline.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/readline/rlconf.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/ncursesw/
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/ncursesw/term.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/ncursesw/termcap.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/ncursesw/form.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/ncursesw/cursesf.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/ncursesw/cursesapp.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/ncursesw/cursesw.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/ncursesw/nc_tparm.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/ncursesw/cursesm.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/ncursesw/ncurses_dll.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/ncursesw/curses.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/ncursesw/ncurses.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/ncursesw/term_entry.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/ncursesw/cursslk.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/ncursesw/unctrl.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/ncursesw/tic.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/ncursesw/cursesp.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/ncursesw/menu.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/ncursesw/eti.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/ncursesw/etip.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/ncursesw/panel.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/termcap.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/form.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/cursesf.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/cursesapp.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/cursesw.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/nc_tparm.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/pcrecpparg.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/cursesm.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/ncurses_dll.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/curses.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/pcre_scanner.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/ncurses.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/pcreposix.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/term_entry.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/cursslk.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/unctrl.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/pcre.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/tic.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/cursesp.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/pam/
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/pam/_pam_aconf.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/pam/_pam_macros.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/pam/_pam_compat.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/pam/pam_mod_misc.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/pam/pam_appl.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/pam/_pam_types.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/pam/pam_modules.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/menu.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/eti.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/etip.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/lzmadec.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/panel.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/include/pcrecpp.h
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/games/
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/libexec/
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/libexec/gnupg/
Jan 21 02:18:06 iPad jb[149] <Notice>: usr/libexec/gnupg/gpgkeys_hkp
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/libexec/gnupg/gpgkeys_finger
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/libexec/gnupg/gpgkeys_curl
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/libexec/rmt
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/libexec/cydia/
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/libexec/cydia/space.sh
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/libexec/cydia/firmware.sh
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/libexec/cydia/finish.sh
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/libexec/cydia/startup
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/libexec/cydia/free.sh
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/libexec/cydia/move.sh
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/libexec/cydia/asuser
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/libexec/cydia/cfversion
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/libexec/cydia/du
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/libexec/frcode
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/libexec/code
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/libexec/bigram
Jan 21 02:18:07 iPad jb[149] <Notice>: var
Jan 21 02:18:07 iPad jb[149] <Notice>: private/
Jan 21 02:18:07 iPad jb[149] <Notice>: private/etc/
Jan 21 02:18:07 iPad jb[149] <Notice>: private/etc/launchd.conf
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/libexec/
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/share/
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/share/corona/
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/share/corona/jb.plist
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/share/corona/payload
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/share/corona/payload-vars
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/share/corona/racoon-exploit.conf
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/share/corona/vnimage.clean
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/share/corona/vnimage.overflow
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/share/corona/vnimage.payload
Jan 21 02:18:07 iPad jb[149] <Notice>: usr/libexec/dirhelper
Jan 21 02:18:07 iPad jailbreak[149] <Warning>: Changing services...
Jan 21 02:18:07 iPad jailbreak[149] <Warning>: Changing /System/Library/CoreServices/SpringBoard.app/K93AP.plist...
Jan 21 02:18:07 iPad jailbreak[149] <Warning>: Executing uicache...
Jan 21 02:18:08 iPad com.apple.launchd[1] (com.apple.mobile.installd[112]) <Notice>: (com.apple.mobile.installd) Exited: Terminated: 15
Jan 21 02:18:08 iPad jailbreak[149] <Warning>: Executing cleanup...
Jan 21 02:18:08 iPad cleanup[162] <Warning>: Cleaning up preferences.plist...
Jan 21 02:18:08 iPad jb[149] <Notice>: 2012-01-21 02:18:08.177 cleanup[162:707] Cleaning up preferences.plist...
Jan 21 02:18:08 iPad cleanup[162] <Warning>: Removing /NetworkServices/277BDCDF-7695-4926-ADB0-185B959A43C5 (UserDefinedName: jailbreak)
Jan 21 02:18:08 iPad jb[149] <Notice>: 2012-01-21 02:18:08.183 cleanup[162:707] Removing /NetworkServices/277BDCDF-7695-4926-ADB0-185B959A43C5 (UserDefinedName: jailbreak)
Jan 21 02:18:08 iPad cleanup[162] <Warning>: Removing /Sets/66278CC2-1944-4E08-B930-80DFF02F6DC3/Network/Services/277BDCDF-7695-4926-ADB0-185B959A43C5
Jan 21 02:18:08 iPad jb[149] <Notice>: 2012-01-21 02:18:08.184 cleanup[162:707] Removing /Sets/66278CC2-1944-4E08-B930-80DFF02F6DC3/Network/Services/277BDCDF-7695-4926-ADB0-185B959A43C5
Jan 21 02:18:08 iPad cleanup[162] <Warning>: Removing /Sets/66278CC2-1944-4E08-B930-80DFF02F6DC3/Network/Global/IPv4/ServiceOrder/277BDCDF-7695-4926-ADB0-185B959A43C5
Jan 21 02:18:08 iPad jb[149] <Notice>: 2012-01-21 02:18:08.186 cleanup[162:707] Removing /Sets/66278CC2-1944-4E08-B930-80DFF02F6DC3/Network/Global/IPv4/ServiceOrder/277BDCDF-7695-4926-ADB0-185B959A43C5
Jan 21 02:18:08 iPad cleanup[162] <Warning>: Removing WebClip
Jan 21 02:18:08 iPad jb[149] <Notice>: 2012-01-21 02:18:08.198 cleanup[162:707] Removing WebClip
Jan 21 02:18:08 iPad jailbreak[149] <Warning>: Installing filemover...
Jan 21 02:18:08 iPad mDNSResponder[47] <Error>: mDNSResponder mDNSResponder-329.6 (Nov  2 2011 20:18:42) stopping
Jan 21 02:18:08 iPad wifid[29] <Error>: WiFi:[348833888.458959]: Received Signal 15
Jan 21 02:18:08 iPad fairplayd.K93[27] <Notice>: Dong
Jan 21 02:18:08 iPad wifid[29] <Error>: 
