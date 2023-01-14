CREATE PROCEDURE [dbo].[spMusic_Filter_by_Composer]
	@Composer varchar(50)
AS

begin
	select *
	FROM dbo.DefaultMusicLibrary
	WHERE Composer = @Composer; 
end

