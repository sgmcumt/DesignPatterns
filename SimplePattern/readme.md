## 简单工厂模式

### 定义

用一个单独的类完成创建对象的过程，即工厂类。

### 介绍

这个模式本身很简单而且使用在业务较简单的情况下。一般用于小项目或者具体产品很少扩展的情况（这样工厂类才不用经常更改）。 它由三种角色组成：

工厂类角色：这是本模式的核心，含有一定的商业逻辑和判断逻辑，根据逻辑不同，产生具体的工厂产品。
抽象产品角色：它一般是具体产品继承的父类或者实现的接口。由接口或者抽象类来实现。
具体产品角色：工厂类所创建的对象就是此角色的实例。在java中由一个具体类实现。

### 优点

（1）很明显，简单工厂的特点就是“简单粗暴”，通过一个含参的工厂方法，我们可以实例化任何产品类，上至飞机火箭，下至土豆面条，无所不能。所以简单工厂有一个别名：上帝类。

### 缺点

（1）任何”东西“的子类都可以被生产，负担太重。当所要生产产品种类非常多时，工厂方法的代码量可能会很庞大。

（2）在遵循开闭原则（对拓展开放，对修改关闭）的条件下，简单工厂对于增加新的产品，无能为力。因为增加新产品只能通过修改工厂方法来实现。

### 举例说明

#### UML示例图

![简单工厂示例](../DesignPatterns/Images/原型类型示意图.jpg)