package com.example.novus_catalog.controllers;

import com.example.novus_catalog.services.StudentServiceImpl;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.servlet.support.ServletUriComponentsBuilder;

import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.stream.Collectors;

@RestController
public class DeleteController {

    @Autowired
    private StudentServiceImpl studentService;

    @PostMapping("/delete")
    public ResponseEntity<Map<String, Object>> deleteStudent(@RequestParam("id") String id) {
        // parse ids
        List<Long> ids = Arrays.stream(id.split(","))
                .map(Long::parseLong)
                .collect(Collectors.toList());
        // delete students
        studentService.deleteAllById(ids);

        String url = ServletUriComponentsBuilder.fromCurrentContextPath()
                .path("/default")// redirect to student list endpoint
                .toUriString();

        Map<String, Object> response = new HashMap<>();
        response.put("redirectToUrl", url);
        return ResponseEntity.ok(response);
    }

}
