using System;
namespace ShitRichardSays.Data
{
    public class Recording
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AudioFile { get; set; }
    }
}
/* Seed data
 * BEGIN;
DROP TABLE IF EXISTS "Recordings";


-- CREATE TABLE "Recordings" -----------------------------------
CREATE TABLE "Recordings"(
	"ID" Integer NOT NULL PRIMARY KEY,
	"Title" Text,
	"AudioFile" Text,
CONSTRAINT "unique_ID" UNIQUE ( "ID" ),
CONSTRAINT "unique_Title" UNIQUE ( "Title" ),
CONSTRAINT "unique_AudioFile" UNIQUE ( "AudioFile" ) );
-- -------------------------------------------------------------

COMMIT;
INSERT INTO "Recordings"("Title","AudioFile")VALUES("Richard Calling Things Stupid","Recordings/ThisIsStupid.m4a");
INSERT INTO "Recordings"("Title","AudioFile")VALUES("Richard Saying Fat","Recordings/RichardSaysFat.m4a");
INSERT INTO "Recordings"("Title","AudioFile")VALUES("Richard Calling People Dumbasses","Recordings/Dumbass.m4a");
INSERT INTO "Recordings"("Title","AudioFile")VALUES("Richard Calling People  Stupid","Recordings/CallingPeopleIdiots.m4a");
 */
