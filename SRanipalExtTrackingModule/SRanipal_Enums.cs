//========= Copyright 2019, HTC Corporation. All rights reserved. ===========
namespace ViveSR
{
    namespace anipal
    {
        public enum AnipalStatus : int
        {
            ERROR,
            IDLE,
            WORKING,
        }

        public enum TrackerInitStatus : int
        {
            SUCCESS,
            NEED_REINIT,
            FAILED
        }
    }
}