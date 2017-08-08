ALTER TABLE Animals
ADD RoomId int
Foreign Key (RoomId) References Room_Number(Id);
