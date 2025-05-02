import 'package:convert_calculate/pages/cal.dart';
import 'package:convert_calculate/pages/contact.dart';
import 'package:convert_calculate/pages/home.dart';
import 'package:flutter/material.dart';

void main(List<String> args) {
  runApp(MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return const MaterialApp(
      home: MainPage()
    );
  }
}

class MainPage extends StatefulWidget {
  const MainPage({super.key});

  @override
  State<MainPage> createState() => _MainPageState();
}

class _MainPageState extends State<MainPage> {

  int _currentIndex = 0;
  final tabs = [HomePage(), CalculatePage(), ContactPage()];

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: Text('แอปคำนวณ_'),
        ),
        body: tabs[_currentIndex],
        bottomNavigationBar: BottomNavigationBar(
          currentIndex: _currentIndex,
          items: [
            BottomNavigationBarItem(icon: Icon(Icons.home), label: 'หน้าหลัก'),
            BottomNavigationBarItem(icon: Icon(Icons.calculate), label: 'คำนวณ'),
            BottomNavigationBarItem(icon: Icon(Icons.contact_page), label: 'ติดต่อ'),
            ],
            onTap: (index){
              setState(() {
                print(index);
                _currentIndex = index;
              });
            },
        ),
      );
  }
}