// 在 http://fsharp.org 上了解有关 F# 的详细信息
// 请参阅“F# 教程”项目以获取更多帮助。
open FsCheck
open Extension
open System

type ListProperties =
    static member ``Char.isLeft``(x: char) = 'a' |> Char.isLeft
    static member ``Char.isRight``(x: char) = 'j' |> Char.isRight
    static member ``Tuple.first``(x: int) = x = ((x, 1) |> Tuple.first)
    static member ``Tuple.second``(x: int) = x = ((x, 1) |> Tuple.first)
    

[<EntryPoint>]
let main argv =
    Check.QuickAll<ListProperties>()
    printfn "%A" argv
    0 // 返回整数退出代码
