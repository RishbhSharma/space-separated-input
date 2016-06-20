#Reads line, splits by SPACE char and appends to array A and maps to INT
A=gets.chomp.split(' ').map(&:to_i) 

#Read Elements of Array
puts A[0].to_s
