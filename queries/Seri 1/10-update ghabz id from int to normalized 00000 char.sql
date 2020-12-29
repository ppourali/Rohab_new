use m_a_db

update ghabz set id=N'0000'+id where len(id)=1
update ghabz set id=N'000'+id where len(id)=2
update ghabz set id=N'00'+id where len(id)=3
update ghabz set id=N'0'+id where len(id)=4

update std set stdno=N'0000'+stdno where len(stdno)=1
update std set stdno=N'000'+stdno where len(stdno)=2
update std set stdno=N'00'+stdno where len(stdno)=3
update std set stdno=N'0'+stdno where len(stdno)=4

update ghabz set stdno=N'0000'+stdno where len(stdno)=1
update ghabz set stdno=N'000'+stdno where len(stdno)=2
update ghabz set stdno=N'00'+stdno where len(stdno)=3
update ghabz set stdno=N'0'+stdno where len(stdno)=4

update payments set id=N'0000'+id where len(id)=1
update payments set id=N'000'+id where len(id)=2
update payments set id=N'00'+id where len(id)=3
update payments set id=N'0'+id where len(id)=4