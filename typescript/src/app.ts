interface User {
  id: number;
  name: string;
  role: "admin" | "dev" | "intern";
}

function greetUser(user: User): string {
  const timestamp = new Date().toISOString();
  return `[${timestamp}] Olá, ${user.role} ${user.name}. Runtime: Node ${process.version}`;
}

const currentUser: User = {
  id: 1,
  name: "Estagiário",
  role: "dev",
};

console.log(greetUser(currentUser));
