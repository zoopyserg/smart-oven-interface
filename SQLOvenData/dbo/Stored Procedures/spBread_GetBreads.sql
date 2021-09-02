CREATE PROCEDURE [dbo].[spBread_GetBreads]
AS
    With AllMinutes AS (
      SELECT tp.Minute, tp.BreadId FROM TemperaturePoints tp
      UNION
      SELECT vp.Minute, vp.BreadId FROM ValvePoints vp
      UNION
      SELECT pp.Minute, pp.BreadId FROM PressurePoints pp
    )

    SELECT Id, Name, (SELECT MAX(Minute) FROM AllMinutes am WHERE am.BreadId = br.Id ) AS Duration
    FROM Breads br
RETURN 0
