using System;


Comment cmvid1num1 = new Comment();
cmvid1num1._commenterName = "DougSimpson21";
cmvid1num1._commentText = "Celine Dion has nothing on this dog!";
Comment cmvid1num2 = new Comment();
cmvid1num2._commenterName = "GOJIRA158";
cmvid1num2._commentText = "Now I want to hear him sing Ain't nothin' but a hound dog!";
Comment cmvid1num3 = new Comment();
cmvid1num3._commenterName = "Link182";
cmvid1num3._commentText = "If he sang Miss You by Blink 182 it would sound like, 'Where are YOUUUOOOOOOooooooOOOoooo!'";
Comment cmvid1num4 = new Comment();
cmvid1num4._commenterName = "Patsy Bailey";
cmvid1num4._commentText = "That dog is so darling!";

Video vid1 = new Video();
vid1._title = "Dog sings karaoke";
vid1._author = "bowwowie12";
vid1._length = 120;
vid1._comments.Add(cmvid1num1);
vid1._comments.Add(cmvid1num2);
vid1._comments.Add(cmvid1num3);
vid1._comments.Add(cmvid1num4);

Comment cmvid2num1 = new Comment();
cmvid2num1._commenterName = "ZackyVengeanceA7X";
cmvid2num1._commentText = "I am so glad that I grew up in the '90s and the 2000s instead of today.";
Comment cmvid2num2 = new Comment();
cmvid2num2._commenterName = "ProteinForce101";
cmvid2num2._commentText = "Kids these days don't do anything but get broccoli cuts and make tik-toks for clout!";
Comment cmvid2num3 = new Comment();
cmvid2num3._commenterName = "Heather Pilgrim";
cmvid2num3._commentText = "As a high school teacher I am so apalled by the lack of writing skills that I see on students' essays with slang such as ''Rizz'' and ''no cap bro''! ";

Video vid2 = new Video();
vid2._title = "This generation is doomed!";
vid2._author = "Matthew Tucker";
vid2._length = 1100;
vid2._comments.Add(cmvid2num1);
vid2._comments.Add(cmvid2num2);
vid2._comments.Add(cmvid2num3);

Comment cmvid3num1 = new Comment();
cmvid3num1._commenterName = "SamusPrime02";
cmvid3num1._commentText = "Man, I've been stuck on the Water Temple since I was a kid! Next is the dungeon boss! Thanks! ";
Comment cmvid3num2 = new Comment();
cmvid3num2._commenterName = "Hyrule180";
cmvid3num2._commentText = "I really needed this for my progress in OT, thanks!";
Comment cmvid3num3 = new Comment();
cmvid3num3._commenterName = "Mario85";
cmvid3num3._commentText = "Ocarina of Time, best Zelda game hands down!";

Video vid3 = new Video();
vid3._title = "Zelda Ocarina of Time - Water Temple Walkthrough part 2(4K)";
vid3._author = "Hard Level Hotline";
vid3._length = 3600;
vid3._comments.Add(cmvid3num1);
vid3._comments.Add(cmvid3num2);
vid3._comments.Add(cmvid3num3);

Video videoCollection = new Video();
videoCollection._videos.Add(vid1);
videoCollection._videos.Add(vid2);
videoCollection._videos.Add(vid3);
videoCollection.ReturnVideos();
videoCollection.ReturnNumberOfComments();



