import 'package:flutter/material.dart';

class CalculatePage extends StatefulWidget {
  const CalculatePage({super.key});

  @override
  State<CalculatePage> createState() => _CalculatePageState();

  
}

class _CalculatePageState extends State<CalculatePage> {

  TextEditingController quantityApple = TextEditingController();
  TextEditingController price = TextEditingController();
  TextEditingController result = TextEditingController();

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    result.text = 'ซื่อแอปเปิ้ลจำนวน x ผล ราคาผลล่ะ x บาท รวมเป็นเงิน x บาท';
  }

  @override
  Widget build(BuildContext context) {
    return ListView(
      children: [
        Padding(
          padding: const EdgeInsets.all(50),
          child: Center(
            child: Column(
              children: [
                Image.asset('assets/apple.png',width: 150,),
                const Text('แอปคำนวณ'),
                TextField(

                  controller: quantityApple,

                  decoration: InputDecoration(
                    labelText: 'จำนวนแอปเปิ้ล', border: OutlineInputBorder()),
                ),
                SizedBox(height: 20,),
                TextField(

                  controller: price,

                  decoration: InputDecoration(
                    labelText: 'ราคาแอปเปิ้ล', border: OutlineInputBorder()),
                ),
                SizedBox(height: 20,),
                ElevatedButton(onPressed: (){
                  var cal = int.parse(quantityApple.text) * int.parse(price.text);
                  
                  setState(() {
                    result.text = 'ซื่อแอปเปิ้ลจำนวน ${quantityApple.text} ผล ราคาผลล่ะ ${price.text} บาท รวมเป็นเงิน $cal บาท';
                  });

                }, child: Text('คำนวณ', style: TextStyle(color: Colors.white),),
                style: const ButtonStyle(backgroundColor: WidgetStatePropertyAll(Color(0xff24a0ed)),
                padding: WidgetStatePropertyAll(EdgeInsets.fromLTRB(50, 20, 50, 20)),
                textStyle: WidgetStatePropertyAll(TextStyle(fontSize: 16)),),),
                Text(result.text, style: TextStyle(fontSize: 16, color: Colors.red),)
              ],
            ),
          ),
        ),
      ],
    );
  }
}