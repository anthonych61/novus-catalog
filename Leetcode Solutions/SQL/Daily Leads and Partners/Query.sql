/* Write your T-SQL query statement below */
Select date_id, make_name, Count(Distinct lead_id) AS unique_leads, Count(Distinct partner_id) AS unique_partners
From DailySales
Group by date_id, make_name;