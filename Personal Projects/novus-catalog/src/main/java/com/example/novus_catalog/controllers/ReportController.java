package com.example.novus_catalog.controllers;

import com.example.novus_catalog.entities.Students;
import com.example.novus_catalog.services.StudentServiceImpl;
import jakarta.servlet.http.HttpSession;
import org.apache.poi.ss.usermodel.Cell;
import org.apache.poi.ss.usermodel.Row;
import org.apache.poi.ss.usermodel.Sheet;
import org.apache.poi.ss.usermodel.Workbook;
import org.apache.poi.xssf.usermodel.XSSFWorkbook;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpHeaders;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

import java.io.ByteArrayOutputStream;
import java.util.*;
import java.util.stream.Collectors;

@RestController
public class ReportController {

    @Autowired
    private StudentServiceImpl studentService;

    @PostMapping("/report")
    public ResponseEntity<Map<String, String>>  generateReport(HttpSession session, @RequestParam String id) throws Exception {
        // parse ids
        List<Long> ids = Arrays.stream(id.split(","))
                .map(Long::parseLong)
                .collect(Collectors.toList());

        // fetch students
        List<Students> students = studentService.findAllById(ids);

        // create excel workbook
        Workbook workbook = new XSSFWorkbook();
        Sheet sheet = workbook.createSheet("Student Report");

       // create header row
        Row header = sheet.createRow(0);
        String[] columns = {"Id", "Firstname", "Lastname", "Gender", "Address", "City", "Department", "School", "Parent Firstname", "Parent Lastname", "PhoneNumber", "DateEnrollment", "Attendance"};
        for (int i = 0; i < columns.length; i++) {
            Cell cell = header.createCell(i);
            cell.setCellValue(columns[i]);
        }

        // fill data rows
        int rowIdx = 1;
        for (Students s : students) {
            Row row = sheet.createRow(rowIdx++);
            row.createCell(0).setCellValue(s.getId());
            row.createCell(1).setCellValue(s.getFirstName());
            row.createCell(2).setCellValue(s.getLastName());
            row.createCell(3).setCellValue(s.getGender());
            row.createCell(4).setCellValue(s.getAddress());
            row.createCell(5).setCellValue(s.getCity());
            row.createCell(6).setCellValue(s.getDepartment());
            row.createCell(7).setCellValue(s.getSchool());
            row.createCell(8).setCellValue(s.getParentFirstName());
            row.createCell(9).setCellValue(s.getParentLastName());
            row.createCell(10).setCellValue(s.getPhoneNumber());
            row.createCell(11).setCellValue(s.getDateEnrolled().toString()); // adapt as needed
            row.createCell(12).setCellValue(s.getAttendance());
        }

        // write to ByteArrayOutputStream
        ByteArrayOutputStream bos = new ByteArrayOutputStream();
        workbook.write(bos);
        workbook.close();
        byte[] excelBytes = bos.toByteArray();
        session.setAttribute("output", excelBytes);

        // save to a location or prepare for download, or return URL
        // return a success message
        Map<String, String> response = new HashMap<>();
        response.put("status","success");

        return ResponseEntity.ok(response);
    }

    @GetMapping("/downloadFile")
    public ResponseEntity<byte[]> downloadFile(HttpSession session, Model model) {
        byte[] byteArray = (byte[]) session.getAttribute("output");
        if (byteArray != null) {
            String filename = "StudentReport_" + java.time.LocalDateTime.now().format(java.time.format.DateTimeFormatter.ofPattern("yyyyMMddHHmmss")) + ".xls";
            return ResponseEntity.ok()
                    .header(HttpHeaders.CONTENT_DISPOSITION, "attachment; filename=\"" + filename + "\"")
                    .contentType(MediaType.parseMediaType("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"))
                    .body(byteArray);
        } else {
            // return 204 no content or 404
            return ResponseEntity.noContent().build();
        }
    }
}
