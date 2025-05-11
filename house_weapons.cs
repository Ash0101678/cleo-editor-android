{$CLEO}
thread "HOUSEWEAPONS"

:START
wait 1000
if
    0256:   player $PLAYER_CHAR defined
jf @START

:LOOP
wait 0
if
    00E1:   key_pressed 0 18  // ALT
jf @LOOP

// بيت CJ - الطابق العلوي
04C4: create_coordinate_weapon_pickup 25 at 2495.743 -1691.207 1014.742 // Shotgun
04C4: create_coordinate_weapon_pickup 31 at 2496.123 -1690.800 1014.742 // M4
04C4: create_coordinate_weapon_pickup 17 at 2496.500 -1690.400 1014.742 // Smoke
04C4: create_coordinate_weapon_pickup 36 at 2497.000 -1690.000 1014.742 // Rocket Launcher (Heat-seeking)

jump @LOOP
